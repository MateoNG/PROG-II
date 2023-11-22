create database [PROGII_1.3_Banco_v2]

use [PROGII_1.3_Banco_v2]

create table Cliente(
cod_cliente int identity(1,1),
nombre varchar(100),
apellido varchar(100),
dni bigint,
constraint pk_clientes primary key (cod_cliente)
)


create table TipoCuenta(
cod_tipoCuenta int identity(1,1),
nombre varchar(100)
constraint pk_tipoCuentas primary key (cod_tipoCuenta)
)

create table Cuenta(
cod_cuenta int identity(1,1),
cbu bigint,
saldo money,
cod_cliente int,
cod_tipoCuenta int,
ultimoMovimiento datetime
constraint pk_cuentas primary key (cod_cuenta),
constraint fk_cuentas_tipocuenta foreign key (cod_tipoCuenta) references TipoCuenta(cod_tipoCuenta),
constraint fk_cuentas_cliente foreign key (cod_cliente) references Cliente(cod_cliente)
)

insert into TipoCuenta Values('Cuenta Corriente')
insert into TipoCuenta Values('Caja de Ahorro')

insert into Cliente Values('Jorge', 'Araujo', 24758839)
insert into Cliente Values(‘Mateo’, 'Gallo', 42069322)

set dateformat dmy
insert into Cuenta Values(000000234045522386061, 1000000, 1, 2, '22/08/2023')
insert into Cuenta Values(000005178748552291881, 50000, 2, 2, '27/08/2023')


--SPs:

create procedure SP_INSERT_CLIENTE
@nombre varchar(100),
@apellido varchar(100),
@dni bigint
as
begin
	insert into Cliente values(@nombre, @apellido, @dni)
end;

------------------------------------------------------------------------------

CREATE procedure SP_CONSULTAR_CLIENTE
@dni bigint
as
begin
select cod_cliente, nombre, apellido, dni
from Cliente
where dni = @dni
order by 1
end;

select * from Cliente
exec SP_CONSULTAR_CLIENTE 42069322

-------------------------------------------------------------

create procedure SP_UPDATE_CLIENTE
@id int,
@nombre varchar(100),
@apellido varchar(100),
@dni bigint
as
begin
update Cliente
set nombre = @nombre, apellido = @apellido, dni = @dni
where cod_cliente = @id
end;

exec SP_UPDATE_CLIENTE 2, 'Perelio', 'Jose', 42069322
exec SP_UPDATE_CLIENTE 2, 'Mateo', 'Gallo', 42069322

------------------------------------------------------------------------------

create procedure SP_CONSULTAR_TIPOCUENTA
as
begin
select *
from TipoCuenta
order by 1
end;

exec SP_CONSULTAR_TIPOCUENTA

--------------------------------------------------------------------------------
create procedure SP_INSERT_CUENTA
@cbu BigInt,
@saldo money,
@codCliente int,
@tipoCuenta int,
@ultMovimiento datetime
as
begin
insert into Cuenta
values (@cbu, @saldo, @codCliente, @tipoCuenta, @ultMovimiento)
end;
--------------------------------------------------------------------------------
createprocedure SP_CONSULTAR_CUENTAS
@codCliente int
as
begin
select cod_cuenta, cbu, saldo, cod_cliente, c.cod_tipoCuenta, ultimoMovimiento, nombre
from Cuenta c join TipoCuenta tc on c.cod_tipoCuenta=tc.cod_tipoCuenta
where cod_cliente = @codCliente
end;

--------------------------------------------------------------------------------
create procedure SP_FILTRAR_CUENTAS
@fecha_desde datetime,
@fecha_hasta datetime,
@cod_tipoCuenta int,
@codCliente int
as
begin
select cod_cuenta, cbu, saldo, cod_cliente, c.cod_tipoCuenta, ultimoMovimiento, nombre
from Cuenta c join TipoCuenta tc on c.cod_tipoCuenta=tc.cod_tipoCuenta
where cod_cliente = @codCliente and c.cod_tipoCuenta = @cod_tipoCuenta and ultimoMovimiento between @fecha_desde and @fecha_hasta
end;
--------------------------------------------------------------------------------
create proc SP_CONSULTAR_DETALLE_CUENTA
@idCuenta int
as
begin
select cod_cuenta, cbu, saldo, cod_cliente, c.cod_tipoCuenta, ultimoMovimiento, nombre
from Cuenta c join TipoCuenta tc on c.cod_tipoCuenta=tc.cod_tipoCuenta
where cod_cuenta = @idCuenta
end;
