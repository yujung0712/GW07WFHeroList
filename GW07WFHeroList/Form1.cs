using Microsoft.EntityFrameworkCore;

namespace GW07WFHeroList {

    public partial class Form1 : Form {
        private AppDbContext _db = new AppDbContext();

        public Form1() {
            InitializeComponent();

            // DB와 테이블이 없으면 생성
            _db.Database.EnsureCreated();

            // Heroes 테이블이 비어있으면 초기 데이터 추가
            // (이름, 역할, 난이도 1~3, 선호도 1~5)
            if (!_db.Heroes.Any()) {
                List<Hero> initialHeroes = [
                    // ===== 돌격 (15) =====
                    // 오버워치 1 영웅: 공식 난이도
                    new("D.Va", "돌격", 2, 4),
                    new("둠피스트", "돌격", 3, 3),
                    new("오리사", "돌격", 2, 3),
                    new("라인하르트", "돌격", 1, 5),
                    new("로드호그", "돌격", 1, 2),
                    new("시그마", "돌격", 2, 3),
                    new("윈스턴", "돌격", 2, 3),
                    new("레킹볼", "돌격", 3, 3),
                    new("자리야", "돌격", 3, 4),
                    // 오버워치 2 이후 영웅: 추정 난이도
                    new("정커퀸", "돌격", 2, 3),
                    new("라마트라", "돌격", 2, 3),
                    new("마우가", "돌격", 1, 3),
                    new("해저드", "돌격", 2, 3),
                    new("도미나", "돌격", 2, 3),
                    new("D.Mon", "돌격", 2, 3),

                    // ===== 공격 (23) =====
                    // 오버워치 1 영웅: 공식 난이도
                    new("애쉬", "공격", 2, 3),
                    new("바스티온", "공격", 1, 3),
                    new("캐서디", "공격", 2, 3),
                    new("에코", "공격", 3, 3),
                    new("겐지", "공격", 3, 5),
                    new("한조", "공격", 3, 4),
                    new("정크랫", "공격", 2, 3),
                    new("메이", "공격", 3, 3),
                    new("파라", "공격", 1, 3),
                    new("리퍼", "공격", 1, 3),
                    new("솔저: 76", "공격", 1, 3),
                    new("시메트라", "공격", 2, 3),
                    new("토르비욘", "공격", 2, 3),
                    new("트레이서", "공격", 2, 4),
                    new("위도우메이커", "공격", 2, 3),
                    // 오버워치 2 이후 영웅: 추정 난이도
                    new("소전", "공격", 2, 3),
                    new("벤처", "공격", 2, 3),
                    new("프레야", "공격", 2, 3),
                    new("벤데타", "공격", 3, 3),
                    new("엠레", "공격", 2, 3),
                    new("안란", "공격", 2, 3),
                    new("시에라", "공격", 2, 3),
                    new("시온", "공격", 3, 3),

                    // ===== 지원 (16) =====
                    // 오버워치 1 영웅: 공식 난이도
                    new("아나", "지원", 3, 4),
                    new("바티스트", "지원", 2, 3),
                    new("브리기테", "지원", 1, 3),
                    new("루시우", "지원", 2, 5),
                    new("메르시", "지원", 1, 5),
                    new("모이라", "지원", 2, 3),
                    new("젠야타", "지원", 3, 3),
                    new("솜브라", "지원", 3, 3),   // 시즌 5에 공격 → 지원으로 변경
                    // 오버워치 2 이후 영웅: 추정 난이도
                    new("키리코", "지원", 2, 4),
                    new("라이프위버", "지원", 2, 3),
                    new("일리아리", "지원", 2, 3),
                    new("주노", "지원", 2, 3),
                    new("우양", "지원", 2, 3),
                    new("제트팩 캣", "지원", 2, 3),
                    new("미즈키", "지원", 2, 3),
                    new("닥트린", "지원", 2, 3)
                ];

                _db.Heroes.AddRange(initialHeroes);
                _db.SaveChanges();
            }

            cmbRole.SelectedIndex = 0;     // 추가할 때 역할 기본값: 돌격
            cmbFilter.SelectedIndex = 0;   // 필터 기본값: 전체
            RefreshList();
        }

        // 필터와 검색 조건에 맞게 목록을 다시 불러오는 함수
        private void RefreshList() {
            var query = _db.Heroes.AsQueryable();

            // 역할 필터
            string role = cmbFilter.SelectedItem?.ToString() ?? "전체";
            if (role != "전체") {
                query = query.Where(h => h.Role == role);
            }

            // 이름 검색
            string keyword = txtSearch.Text.Trim();
            if (keyword != "") {
                query = query.Where(h => h.Name.Contains(keyword));
            }

            // 역할별 → 선호도 높은 순 → 난이도 쉬운 순
            var result = query
                .OrderBy(h => h.Role)
                .ThenByDescending(h => h.Favorite)
                .ThenBy(h => h.Difficulty)
                .ToList();

            listHero.Items.Clear();
            foreach (var hero in result) {
                listHero.Items.Add(hero);
            }

            lblCount.Text = $"총 {result.Count}명";
        }

        // 필터를 바꾸거나 검색어를 입력할 때
        private void OnFilterChanged(object sender, EventArgs e) {
            RefreshList();
        }

        // 추가 버튼
        private void OnAdd(object sender, EventArgs e) {
            string name = txtName.Text.Trim();

            if (name == "") {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }
            if (_db.Heroes.Any(h => h.Name == name)) {
                MessageBox.Show("이미 목록에 있는 영웅입니다.");
                return;
            }

            string role = cmbRole.SelectedItem?.ToString() ?? "돌격";
            int difficulty = (int)numDifficulty.Value;
            int favorite = (int)numFavorite.Value;

            _db.Heroes.Add(new Hero(name, role, difficulty, favorite));
            _db.SaveChanges();   // DB에 저장

            txtName.Clear();
            RefreshList();
        }

        // 삭제 버튼
        private void OnDelete(object sender, EventArgs e) {
            if (listHero.SelectedItem is not Hero hero) {
                MessageBox.Show("삭제할 영웅을 목록에서 선택하세요.");
                return;
            }

            var answer = MessageBox.Show($"{hero.Name}을(를) 삭제할까요?", "삭제 확인",
                                         MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes) {
                return;
            }

            _db.Heroes.Remove(hero);
            _db.SaveChanges();   // DB에서 삭제
            RefreshList();
        }
    }

    // 영웅 한 명의 정보 (DB 테이블의 한 줄)
    public record Hero(string Name, string Role, int Difficulty, int Favorite) {
        public int Id { get; init; }   // 기본 키 (DB가 자동으로 번호 매김)

        // ListBox에 표시될 형식: [역할] 이름   난이도 ★★☆   선호 ⭐4
        public override string ToString() =>
            $"[{Role}] {Name}   난이도 {new string('★', Difficulty)}{new string('☆', 3 - Difficulty)}   선호 ⭐{Favorite}";
    }

    // DB 연결 통로
    public class AppDbContext : DbContext {
        public DbSet<Hero> Heroes { get; set; }   // Heroes 테이블

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=heroes.db");
        }
    }
}