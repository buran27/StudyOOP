
// using Study.Mediator;
using Study.Tree;

// var chatRoom = new ChatRoomMediator();

// var user1 = new ChatUser("User1", chatRoom);
// var user2 = new ChatUser("User2", chatRoom);
// var user3 = new ChatUser("User3", chatRoom);

// chatRoom.RegisterUser(user1);
// chatRoom.RegisterUser(user2);
// chatRoom.RegisterUser(user3);

// user1.Send("Hello user2 and user3");

// user2.Send("Hello user1 and usser3");

// user3.Send("Hello user1 and user2");



var root = new TreeNode("Root");

var electronics = new TreeNode("Electronics");
var books = new TreeNode("Books");
var clothes = new TreeNode("Clothes");

var phones = new TreeNode("Phones");
var laptops = new TreeNode("Laptops");
var fiction = new TreeNode("Fiction");
var science = new TreeNode("Science");
var men = new TreeNode("Men");
var women = new TreeNode("Women");

var android = new TreeNode("Android");
var iphone = new TreeNode("iPhone");
var gaming = new TreeNode("Gaming Laptop");
var ultrabook = new TreeNode("Ultrabook");

root.AddChild(electronics);
root.AddChild(books);
root.AddChild(clothes);

electronics.AddChild(phones);
electronics.AddChild(laptops);

books.AddChild(fiction);
books.AddChild(science);

clothes.AddChild(men);
clothes.AddChild(women);

phones.AddChild(android);
phones.AddChild(iphone);

laptops.AddChild(gaming);
laptops.AddChild(ultrabook);

Console.WriteLine("Current node value:");
root.PrintNode();

Console.WriteLine("\nChildren of root:");
root.PrintChildren();

Console.WriteLine("\nRecursive tree traversal:");
root.Traverse();

