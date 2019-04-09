using System;
using System.Threading.Tasks;
using Mastonet;

namespace mstdn_sample {
    class Program {
        static async Task Main(string[] args) {
            /*
             * .NET Coreを使ってMastdonへトュートするサンプル
            */
            Console.WriteLine("Hello World!");

            //インスタンスの指定
            var authClient = new AuthenticationClient("mstdn.jp");
            //アプリケーション作成＆認証後の権限指定
            var appRegistration = await authClient.CreateApp("テストAPP", Scope.Read | Scope.Write | Scope.Follow);

            //OAuthの認証コード表示URL取得
            var url = authClient.OAuthUrl();
            //取得したURL表示
            Console.WriteLine(url);

            //前段で取得した認証コードをコンソールに入力
            var authCode = Console.ReadLine();
            //認証実行
            var auth = await authClient.ConnectWithCode(authCode);

            //アプリケーション + 認証情報でマストドンクライアントを生成
            var client = new MastodonClient(appRegistration, auth);

            //トュート内容設定
            var post_str = "テスト トュート！";

            //トュート！
            await client.PostStatus(post_str, Visibility.Public);
        }
    }
}
