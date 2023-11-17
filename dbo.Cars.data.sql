﻿SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([Id], [Brand], [Model], [ProductionYear], [Mileage], [Capacity], [FuelType], [Power], [Description], [Price], [PhotoUrl], [ThumbnailUrl], [IsCarOfTheWeek]) VALUES (1, N'Frod', N'Mustang', 2016, N'20 000 mi', N'4 900 cm3', N'gas', N'421 HP', N'xxx', CAST(160000.00 AS Decimal(18, 2)), N'/images/fordMustang.jpg', N'/images/fordMustang.jpg', 1)
INSERT INTO [dbo].[Cars] ([Id], [Brand], [Model], [ProductionYear], [Mileage], [Capacity], [FuelType], [Power], [Description], [Price], [PhotoUrl], [ThumbnailUrl], [IsCarOfTheWeek]) VALUES (2, N'Audi', N'S5', 2013, N'66 000 mi', N'3 000 cm3', N'gas', N'280 HP', N'xxx', CAST(115000.00 AS Decimal(18, 2)), N'/images/audiS5.jpg', N'/images/audiS5.jpg', 0)
INSERT INTO [dbo].[Cars] ([Id], [Brand], [Model], [ProductionYear], [Mileage], [Capacity], [FuelType], [Power], [Description], [Price], [PhotoUrl], [ThumbnailUrl], [IsCarOfTheWeek]) VALUES (3, N'BMW', N'X4', 2017, N'2500 mi', N'1995 cm3', N'gas', N'190 HP', N'xxx', CAST(194000.00 AS Decimal(18, 2)), N'/images/bmwX4.jpg', N'/images/bmwX4.jpg', 0)
SET IDENTITY_INSERT [dbo].[Cars] OFF
