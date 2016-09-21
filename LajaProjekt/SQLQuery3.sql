SELECT [Table].[Nazwa], [Table].[Kategoria], Sum([Table2].[ilosc]) as "Ilość", case when [Table2].[discount] != 0 then CONVERT(varchar(10),([Table2].[discount]) * 100) + '%' else '-' end as "Zniżka", [Table].[Cena],  round(sum((Table2.ilosc * [Table].Cena) * (1.0 - Table2.discount)), 2) as "Kwota", CONVERT(varchar(10), [Table2].[day]) + '.' + CONVERT(varchar(10), [Table2].[month]) + '.' + CONVERT(varchar(10), [Table2].[year]) as "Data"
FROM [Table2]
INNER JOIN [Table]
ON [Table2].[Id_prod]=[Table].[Id]
GROUP BY  [Table].[Nazwa], [Table].[Kategoria], [Table2].[discount], [Table].[Cena], [Table2].[day], [Table2].[month], [Table2].[year]
ORDER BY [Table2].[year] DESC, [Table2].[day] ASC, [Table2].[month] ASC, [Table].[Nazwa] ASC
