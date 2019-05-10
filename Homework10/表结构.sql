create table Orders
(
  Id         varchar(128) not null
    primary key,
  Customer   longtext     null,
  CreateTime datetime     not null
);

create table OrderDetails
(
  Id        varchar(128) not null
    primary key,
  Product   longtext     null,
  UnitPrice double       not null,
  Quantity  int          not null,
  Order_Id  varchar(128) null,
  constraint Order_Details
  foreign key (Order_Id) references Orders (Id)
);

create index Order_Id
  on OrderDetails (Order_Id);

create table `__MigrationHistory`
(
  MigrationId    varchar(150) not null,
  ContextKey     varchar(300) not null,
  Model          longblob     not null,
  ProductVersion varchar(32)  not null,
  primary key (MigrationId, ContextKey)
);
