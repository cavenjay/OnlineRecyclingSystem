IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210629220435_createOrderTable')
BEGIN
    CREATE TABLE [Order] (
        [ID] int NOT NULL IDENTITY,
        [OrderDate] datetime2 NOT NULL,
        [CusName] nvarchar(max) NULL,
        [CusContact] nvarchar(max) NULL,
        [CusAddress] nvarchar(max) NULL,
        [BigBottle] nvarchar(max) NULL,
        [SmallBottle] nvarchar(max) NULL,
        [Can] nvarchar(max) NULL,
        [DriverName] nvarchar(max) NULL,
        [DriverContact] nvarchar(max) NULL,
        [OrderStatus] nvarchar(max) NULL,
        CONSTRAINT [PK_Order] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210629220435_createOrderTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210629220435_createOrderTable', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630052729_addOrderTime')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Order]') AND [c].[name] = N'CusName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Order] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Order] ALTER COLUMN [CusName] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630052729_addOrderTime')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Order]') AND [c].[name] = N'CusContact');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Order] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Order] ALTER COLUMN [CusContact] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630052729_addOrderTime')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Order]') AND [c].[name] = N'CusAddress');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Order] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Order] ALTER COLUMN [CusAddress] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630052729_addOrderTime')
BEGIN
    ALTER TABLE [Order] ADD [OrderTime] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630052729_addOrderTime')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210630052729_addOrderTime', N'3.1.15');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210630053030_addOrderTime2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210630053030_addOrderTime2', N'3.1.15');
END;

GO

