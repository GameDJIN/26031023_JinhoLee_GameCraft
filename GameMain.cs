class GameMain : G2AppBase
{
    public override System.Drawing.Size ScreenSize => GameGlobal.ScreenSize;
    public override string GameName => GameGlobal.GameName;

    protected override void Initialize()
    {
        ClearColor = new(0.02f, 0.03f, 0.08f, 1.0f);
        // 이미지와 사운드는 이후 이곳에서 불러옵니다.
    }

    protected override void Update()
    {
        // 입력과 전투 처리는 이후 추가합니다.
    }

    protected override void Render()
    {
        // 이미지 출력은 이후 추가합니다.
    }
}
