create procedure sp_ListarCategorias
	@buscar varchar(50) = ''
as
begin
	select 
		c.IdCategoria, 
		c.Nombre as CategoriaNombre, 
		c.IdMedida, 
		m.Nombre as MedidaNombre, 
		c.Activo
	from Categorias c
	inner join Medidas m on m.IdMedida = c.IdMedida
	where c.Nombre like '%' + @buscar + '%'
end
go

create procedure sp_CrearCategoria
	@nombre varchar(50), 
	@idMedida int 
as
begin
	insert into Categorias(Nombre,IdMedida)
	values (@nombre, @idMedida)
end
go

create procedure sp_EditarCategoria
	@idCategoria int,
	@nombre varchar(50), 
	@idMedida int, 
	@activo int
as
begin
	update Categorias set 
		Nombre = @nombre,
		IdMedida = @idMedida,
		Activo = @activo
	where IdCategoria = @idCategoria
end
go


sp_help Categorias