/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2018-09-10 20:44:23                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrow_record') and o.name = 'FK_BORROW_R_BORROW_RE_USER')
alter table borrow_record
   drop constraint FK_BORROW_R_BORROW_RE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrow_record') and o.name = 'FK_BORROW_R_BORROW_RE_BOOK')
alter table borrow_record
   drop constraint FK_BORROW_R_BORROW_RE_BOOK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('book')
            and   type = 'U')
   drop table book
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('borrow_record')
            and   name  = 'borrowrecord2_FK'
            and   indid > 0
            and   indid < 255)
   drop index borrow_record.borrowrecord2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('borrow_record')
            and   name  = 'borrowrecord_FK'
            and   indid > 0
            and   indid < 255)
   drop index borrow_record.borrowrecord_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('borrow_record')
            and   type = 'U')
   drop table borrow_record
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"user"')
            and   type = 'U')
   drop table "user"
go

/*==============================================================*/
/* Table: book                                                  */
/*==============================================================*/
create table book (
   b_id                 bigint               identity,
   title                varchar(128)         not null,
   author               varchar(64)          not null,
   isbn                 varchar(32)          not null,
   abstract             text                 null,
   category             varchar(64)          null,
   imageurl             varchar(256)         null,
   presscompany         varchar(64)          not null,
   count                int                  not null,
   publishdate          datetime             not null,
   inlibdate            datetime             not null,
   position             varchar(128)         null,
   bookremark           text                 null,
   constraint PK_BOOK primary key nonclustered (b_id)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   '�鼮��Ϣ��',
   'user', @CurrentUser, 'table', 'book'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮UID',
   'user', @CurrentUser, 'table', 'book', 'column', 'b_id'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮����',
   'user', @CurrentUser, 'table', 'book', 'column', 'title'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮����',
   'user', @CurrentUser, 'table', 'book', 'column', 'author'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ISBN��',
   'user', @CurrentUser, 'table', 'book', 'column', 'isbn'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'ժҪ',
   'user', @CurrentUser, 'table', 'book', 'column', 'abstract'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮���',
   'user', @CurrentUser, 'table', 'book', 'column', 'category'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮����·��',
   'user', @CurrentUser, 'table', 'book', 'column', 'imageurl'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '������',
   'user', @CurrentUser, 'table', 'book', 'column', 'presscompany'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����',
   'user', @CurrentUser, 'table', 'book', 'column', 'count'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����ʱ��',
   'user', @CurrentUser, 'table', 'book', 'column', 'publishdate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ʱ��',
   'user', @CurrentUser, 'table', 'book', 'column', 'inlibdate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���λ��',
   'user', @CurrentUser, 'table', 'book', 'column', 'position'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮��ע',
   'user', @CurrentUser, 'table', 'book', 'column', 'bookremark'
go

/*==============================================================*/
/* Table: borrow_record                                         */
/*==============================================================*/
create table borrow_record (
   uid                  bigint               not null,
   b_id                 bigint               not null,
   borrowcount          int                  not null,
   borrowdate           datetime             not null,
   returndate           datetime             not null,
   validdate            datetime             not null,
   status               varchar(32)          not null,
   fee                  decimal              not null default 0,
   reborrow             int                  null default 0
      constraint CKC_REBORROW_BORROW_R check (reborrow is null or (reborrow between 0 and 10)),
   constraint PK_BORROW_RECORD primary key (uid, b_id)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   '���ļ�¼',
   'user', @CurrentUser, 'table', 'borrow_record'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�UID',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'uid'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮UID',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'b_id'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�������',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'borrowcount'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ʱ��',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'borrowdate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�黹ʱ��',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'returndate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '��Чʱ��',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'validdate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�鼮״̬',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'status'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '���ڷ���',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'fee'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�������',
   'user', @CurrentUser, 'table', 'borrow_record', 'column', 'reborrow'
go

/*==============================================================*/
/* Index: borrowrecord_FK                                       */
/*==============================================================*/
create index borrowrecord_FK on borrow_record (
uid ASC
)
go

/*==============================================================*/
/* Index: borrowrecord2_FK                                      */
/*==============================================================*/
create index borrowrecord2_FK on borrow_record (
b_id ASC
)
go

/*==============================================================*/
/* Table: "user"                                                */
/*==============================================================*/
create table "user" (
   uid                  bigint               identity,
   name                 varchar(64)          not null,
   account              varchar(64)          not null,
   password             varchar(64)          not null,
   permission           varchar(32)          null,
   createdate           datetime             null,
   lastlogin            timestamp            null,
   userremark           text                 null,
   user_status          varchar(32)          not null,
   constraint PK_USER primary key nonclustered (uid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sys.sp_addextendedproperty 'MS_Description', 
   '�û���Ϣ��',
   'user', @CurrentUser, 'table', 'user'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�UID',
   'user', @CurrentUser, 'table', 'user', 'column', 'uid'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û���',
   'user', @CurrentUser, 'table', 'user', 'column', 'name'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�˻�',
   'user', @CurrentUser, 'table', 'user', 'column', 'account'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�˻�����',
   'user', @CurrentUser, 'table', 'user', 'column', 'password'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Ȩ��',
   'user', @CurrentUser, 'table', 'user', 'column', 'permission'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '����ʱ��',
   'user', @CurrentUser, 'table', 'user', 'column', 'createdate'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�ϴε�¼ʱ��',
   'user', @CurrentUser, 'table', 'user', 'column', 'lastlogin'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û���ע',
   'user', @CurrentUser, 'table', 'user', 'column', 'userremark'
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '�û�״̬',
   'user', @CurrentUser, 'table', 'user', 'column', 'user_status'
go

alter table borrow_record
   add constraint FK_BORROW_R_BORROW_RE_USER foreign key (uid)
      references "user" (uid)
go

alter table borrow_record
   add constraint FK_BORROW_R_BORROW_RE_BOOK foreign key (b_id)
      references book (b_id)
go

