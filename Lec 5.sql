create table Bobashop2(
    id int primary key identity(100,2),
    name varchar(30)
)

insert bobashop2 values ('Chai'),('milk'),('tea')
insert bobashop2 values ('latte'),('green tea'),('black tea')
select * from Bobashop2

TRUNCATE table bobashop2
-- Truncate vs delete
-- Delete can be used to remove one or more records
-- Truncate will remove all records and we cannot use the where clauses
-- Delete is a DML statement (will not reset identity), truncate is a DDL statement (will reset identity)

Begin TRANSACTION
delete bobashop2
rollback