SELECT
p.Name Product, c.Name Category
FROM ProductCategor pc
Right JOIN Productt p ON p.ID = pc.IdProduct
LEFT JOIN Categor c ON c.ID = pc.IdCategor