SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([Id], [Brand], [Model], [ProductionYear], [Mileage], [Capacity], [FuelType], [Power], [Description], [Price], [PhotoUrl], [ThumbnailUrl], [IsCarOfTheWeek]) VALUES (1, N'Ford', N'Mustang', 2016, N'20 000 mi', N'4 900 cm3', N'gas', N'421 KM', N'xxx', CAST(160000.00 AS Decimal(18, 2)), N'/images/fordMustang.jpg', N'/images/fordMustang.jpg', 1)
SET IDENTITY_INSERT [dbo].[Cars] OFF
