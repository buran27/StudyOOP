
using Study.Mediator;

var chatRoom = new ChatRoomMediator();

var user1 = new ChatUser("User1", chatRoom);
var user2 = new ChatUser("User2", chatRoom);
var user3 = new ChatUser("User3", chatRoom);

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);
chatRoom.RegisterUser(user3);

user1.Send("Hello user2 and user3");

user2.Send("Hello user1 and usser3");

user3.Send("Hello user1 and user2");




