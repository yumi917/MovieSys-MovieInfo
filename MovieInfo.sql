create database MovieDB

create table Movie
(
   MID	int primary key identity(1,1),
   MovieImage varchar(200),
   MovieName Nvarchar(200),
   MainPerformer Nvarchar(100),
   MovieTypeId varchar(20),
   Area	nvarchar(10),
   TimeLength varchar(20),
   OnTime	date,
   Synopsis	Nvarchar(400),
   ShowStarTime	date,
   ShowEndTime	date,
   MovieState	char(2)

)


insert into Movie(MovieImage,MovieName)
values 
('D:\2019皇家工程\作业\zero\影片图片\X战警：黑凤凰.jpg','X战警：黑凤凰')
insert into Movie(MovieImage,MovieName,MainPerformer,MovieTypeId,Area,TimeLength,OnTime,Synopsis,ShowStarTime,ShowEndTime,MovieState)
values 
('D:\2019皇家工程\作业\zero\影片图片\阿拉丁.jpg','阿拉丁','梅纳·玛索德、娜奥米·斯科特、马尔万·肯扎里','爱情','美国','128','2019-05-24','在充满异域风情的古代阿拉伯王国，善良的穷小子阿拉丁（莫纳·马苏德 饰）和勇敢的茉莉公主（娜奥米·斯科特 饰）浪漫邂逅，在可以满足主人三个愿望的神灯精灵帮助下，两人踏上了一次寻找真爱和自我的魔幻冒险。','2019-5-20','2019-7-20','1'),
('D:\2019皇家工程\作业\zero\影片图片\八尺·一声一世.jpg','八尺·一声一世','佐藤康夫、小凑昭尚、蔡鸿文','纪录片','中国大陆 ','91','2019-05-31','《尺八·一声一世》是聿馨导演历时三年拍摄的音乐人文纪录电影，片中记录了中日美等地的尺八演奏家，制管师，学习者的生活，通过他们的尺八之路，映照出每个人对音乐，生活，生命及世界的认知与感悟。为大众展现了生活的另一种可能。 尺八，是源于中国的竹制吹管乐器，因管长一尺八寸得名，音色苍凉辽阔，曾兴于盛唐，南宋后在中国式微，而在日本传承至今。如今作为《火影忍者》《阴阳师》等影视动漫配乐逐渐被中国年轻人所知。','2019-5-20','2019-7-20','1')
select * from Movie

insert into Movie(MovieName,MainPerformer,MovieTypeId,Area,TimeLength,OnTime,MovieState,Synopsis) values ('波西米亚狂想曲','拉米·马雷克、本·哈迪','英国','音乐','134','2019/3/22 0:00:00','1','佛莱德·摩克瑞（拉米·马雷克 饰）曾是希思罗机场的一名普通搬运工，对音乐满腔热血的他，与布莱恩·梅（格威利姆·李 饰）、罗杰·泰勒（本·哈迪 饰）、约翰·迪肯（约瑟夫·梅泽罗 饰）组成皇后乐队。这个殿堂级乐队的从无到有，从疏离到重聚，从低谷到巅峰，仿佛就是佛莱德一生的缩影。在最后的日子里，佛莱德做了生命中最重要的决定——在音乐史上最伟大的“拯救生命”大型摇滚乐演唱会上，将所有热血付诸于歌声。')

update Movie set MovieName='13',MainPerformer='1',MovieTypeId='美国',Area='冒险',TimeLength='1',OnTime='2019/6/9 0:00:00',MovieState='0',Synopsis='' where MID=3

--以下未使用
create table Customer
(
   UserID int primary key identity(1,1),
   UserName nvarchar(30) not null,
   UserPassword nvarchar(100),
   UserSex char(2), 
   DateBirth datetime,
   PhoneNumber nvarchar(30),
   UserAccount nvarchar(50),
   TicketPurchase nvarchar(100)
)
create table Orders
(
   ID int primary key identity(1,1),
   HallID int,
   Seat	int,
   TicketPrice  decimal(4,2),
   Discount	 decimal(4,2),
   DTime datetime,
   userState char(2)
)
create table OrderSeat
(
   ID int primary key identity(1,1),
   OrderID int,
   SeatID varchar(20)

)
create table Hall
(
   HallID int,
   SeatSeats varchar(20),
   HallDescription varchar(100)
)
create table Schedule 
(
   ScheduleID int,
   MovieID Int,
   HallID Int,
   Price varchar(20),
   BeginDateTime varchar(20)
)
create table Seat 
(
   SeatID	int,
   HallID	Int,
   RowSeat	varchar(20),
   ColumnSeat	varchar(20),
   IsActive	varchar(20)
)
