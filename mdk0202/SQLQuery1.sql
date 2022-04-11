CREATE TRIGGER trChangeCount
on OrderContents
instead of insert
as begin
declare @q smallint;
declare @k smallint;
select @q = Quantity, @k = [Count]
from Products join inserted
on Products.IdProduct = inserted.IdProduct;

if (@q<=@k)
begin 
insert into OrderContents(IdProduct, Quantity)
select IdProduct, @q
from inserted
update Products
set [Count] = [Count]-@q
from Products
JOIN inserted ON Products.IdProduct = inserted.IdProduct
end;
end