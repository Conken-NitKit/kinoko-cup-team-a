# TeamA
### 気をつけること！！  
・ブランチの命名規則　feature/#(issueの番号)  
・pushする前にdevelopの変更をとってくる＝”git pull origin develop”を実行した後にpush  
・作業する前に今いるブランチの確認をする＝”git branch”を実行  
・コミットメッセージは　”作成：タイトル画面を作成”のように、”概要：詳しく説明”の形でかく  
・ブランチを切るときは一度developに戻り、pullした後に切る  
### コードについて  
・関数やクラスの前にはsummaryタグを付ける  
→コメントアウトには、どういう処理をするのか詳しく書く  
・変数、メソッドは基本的にはprivate  
・Inspectorで扱いたいprivate変数には[SerializeField]をつける  
・マジックナンバーは使わない  
・メソッドの名前は動詞で始める  
・変数名と引数はhappyBirthdayのように最初を小文字にする  
・それ以外(クラスとかメソッドとか)はHappyBirthdayのように最初も大文字にする
