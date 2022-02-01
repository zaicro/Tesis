ALTER TRIGGER [dbo].[tg_facturas]
ON [dbo].[facturas]
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;
	UPDATE
		Tabla_A
	SET
		Tabla_A.orden_venta_id = Tabla_B.id
	FROM
		[dbo].[facturas] AS Tabla_A
		INNER JOIN [dbo].[ordenes_venta] AS Tabla_B
			ON Tabla_A.orden_venta = Tabla_B.orden_venta
	--UPDATE
	--	Tabla_A
	--SET
	--	Tabla_A.orden_venta_id = Tabla_B.ordenes_venta
	--FROM
	--	[dbo].[facturas] AS Tabla_A
	--	INNER JOIN [dbo].[Ingreso] AS Tabla_B
	--		ON Tabla_A.id = Tabla_B.facturas
END