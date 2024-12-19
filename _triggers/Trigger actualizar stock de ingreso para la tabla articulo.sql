use dbsistema

create trigger Ingreso_ActualizarStock
On detalle_ingreso
for insert
as 
update a set a.stock=a.stock+d.cantidad
from articulo as a inner join inserted as d on d.idarticulo=a.idarticulo
go