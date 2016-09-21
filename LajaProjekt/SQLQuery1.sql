SELECT [Table].[Nazwa], [Table].[Kategoria], [Table2].[ilosc], [Table].[Cena], [Table2].[ilosc] * [Table].[Cena] as "kwota"
FROM [Table2]
INNER JOIN [Table]
ON [Table2].[Id_prod]=[Table].[Id]