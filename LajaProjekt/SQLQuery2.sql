SELECT [Table2].[Id], [Table2].[Id_prod], [Table].[Nazwa], [Table].[Kategoria], [Table2].[ilosc], [Table2].[discount], [Table].[Cena], [Table2].[day], [Table2].[month], [Table2].[year], round( [Table2].[ilosc] * [Table].[Cena] * (1.0 - [Table2].[discount]),2) as "kwota", [Table2].[day], CONVERT(varchar(10), [Table2].[day]) + '.' + CONVERT(varchar(10), [Table2].[month]) + '.' + CONVERT(varchar(10), [Table2].[year]) as "data"
FROM [Table2]
INNER JOIN [Table]
ON [Table2].[Id_prod]=[Table].[Id]