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
('D:\2019�ʼҹ���\��ҵ\zero\ӰƬͼƬ\Xս�����ڷ��.jpg','Xս�����ڷ��')
insert into Movie(MovieImage,MovieName,MainPerformer,MovieTypeId,Area,TimeLength,OnTime,Synopsis,ShowStarTime,ShowEndTime,MovieState)
values 
('D:\2019�ʼҹ���\��ҵ\zero\ӰƬͼƬ\������.jpg','������','÷�ɡ������¡��Ȱ��ס�˹���ء�����򡤿�����','����','����','128','2019-05-24','�ڳ����������ĹŴ���������������������С�Ӱ�������Ī�ɡ����յ� �Σ����¸ҵ����������Ȱ��ס�˹���� �Σ��������ˣ��ڿ���������������Ը������ƾ�������£�����̤����һ��Ѱ���氮�����ҵ�ħ��ð�ա�','2019-5-20','2019-7-20','1'),
('D:\2019�ʼҹ���\��ҵ\zero\ӰƬͼƬ\�˳ߡ�һ��һ��.jpg','�˳ߡ�һ��һ��','���ٿ���С�����С��̺���','��¼Ƭ','�й���½ ','91','2019-05-31','���߰ˡ�һ��һ�������ܰ������ʱ����������������ļ�¼��Ӱ��Ƭ�м�¼���������ȵصĳ߰�����ң��ƹ�ʦ��ѧϰ�ߵ����ͨ�����ǵĳ߰�֮·��ӳ�ճ�ÿ���˶����֣�����������������֪�����Ϊ����չ�����������һ�ֿ��ܡ� �߰ˣ���Դ���й������ƴ�����������ܳ�һ�߰˴��������ɫ����������������ʢ�ƣ����κ����й�ʽ΢�������ձ��������������Ϊ����Ӱ���ߡ�������ʦ����Ӱ�Ӷ��������𽥱��й���������֪��','2019-5-20','2019-7-20','1')
select * from Movie

insert into Movie(MovieName,MainPerformer,MovieTypeId,Area,TimeLength,OnTime,MovieState,Synopsis) values ('�������ǿ�����','���ס����׿ˡ���������','Ӣ��','����','134','2019/3/22 0:00:00','1','�����¡�Ħ�������ס����׿� �Σ�����ϣ˼�޻�����һ����ͨ���˹�����������ǻ��Ѫ�������벼������÷��������ķ���� �Σ����޽ܡ�̩�գ��������� �Σ���Լ�����Ͽϣ�Լɪ��÷���� �Σ���ɻʺ��ֶӡ�������ü��ֶӵĴ��޵��У������뵽�ؾۣ��ӵ͹ȵ��۷壬�·���Ƿ�����һ������Ӱ���������������������������������Ҫ�ľ�������������ʷ����ΰ��ġ���������������ҡ�����ݳ����ϣ���������Ѫ�����ڸ�����')

update Movie set MovieName='13',MainPerformer='1',MovieTypeId='����',Area='ð��',TimeLength='1',OnTime='2019/6/9 0:00:00',MovieState='0',Synopsis='' where MID=3

--����δʹ��
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
