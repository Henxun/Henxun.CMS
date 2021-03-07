use HenxunCms
go
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TaskInfo'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'Permission'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsDisplay'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Permission'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'LinkUrl'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IconUrl'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'DisplayName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'RoleType'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddIp'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddManagerNickName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddManageId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'ActionType'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'IsLock'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginLastTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginLastIp'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginCount'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'NickName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Avatar'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoKeywords'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ImageUrl'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ClassLayer'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ClassList'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsPublish'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsRed'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsSlide'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsTop'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoKeyword'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Source'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ViewCount'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ImageUrl'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Id'
GO
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_ROLEPERM_RELATIONS_MENU]
GO
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_ROLEPERM_RELATIONS_MANAGERR]
GO
ALTER TABLE [dbo].[ManagerLog] DROP CONSTRAINT [FK_MANAGERL_RELATIONS_MANAGER]
GO
ALTER TABLE [dbo].[Manager] DROP CONSTRAINT [FK_MANAGER_RELATIONS_MANAGERR]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [FK_ARTICLE_RELATIONS_ARTICLEC]
GO
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF_Menu_IsDelete]
GO
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF__Menu__AddTime__440B1D61]
GO
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF_Menu_IsSystem]
GO
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF_Menu_IsDisplay]
GO
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [DF_Menu_Sort]
GO
ALTER TABLE [dbo].[ManagerRole] DROP CONSTRAINT [DF__ManagerRo__AddTi__412EB0B6]
GO
ALTER TABLE [dbo].[ManagerLog] DROP CONSTRAINT [DF__ManagerLo__AddTi__3E52440B]
GO
ALTER TABLE [dbo].[Manager] DROP CONSTRAINT [DF__Manager__IsDelet__3B75D760]
GO
ALTER TABLE [dbo].[Manager] DROP CONSTRAINT [DF__Manager__IsLock__3A81B327]
GO
ALTER TABLE [dbo].[Manager] DROP CONSTRAINT [DF__Manager__AddTime__398D8EEE]
GO
ALTER TABLE [dbo].[ArticleCategory] DROP CONSTRAINT [DF__ArticleCa__IsDel__36B12243]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__IsDelet__33D4B598]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__IsPubli__32E0915F]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__IsRed__31EC6D26]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__IsSlide__30F848ED]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__IsTop__300424B4]
GO
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [DF__Article__AddTime__2F10007B]
GO
/****** Object:  Index [PK_ROLEPERMISSION]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [PK_ROLEPERMISSION]
GO
/****** Object:  Index [PK_MENU]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Menu] DROP CONSTRAINT [PK_MENU]
GO
/****** Object:  Index [PK_MANAGERROLE]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ManagerRole] DROP CONSTRAINT [PK_MANAGERROLE]
GO
/****** Object:  Index [PK_MANAGERLOG]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ManagerLog] DROP CONSTRAINT [PK_MANAGERLOG]
GO
/****** Object:  Index [PK_MANAGER]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Manager] DROP CONSTRAINT [PK_MANAGER]
GO
/****** Object:  Index [PK_ARTICLECATEGORY]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ArticleCategory] DROP CONSTRAINT [PK_ARTICLECATEGORY]
GO
/****** Object:  Index [PK_ARTICLE]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [PK_ARTICLE]
GO
/****** Object:  Table [dbo].[TaskInfo]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[TaskInfo]
GO
/****** Object:  Table [dbo].[RolePermission]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[RolePermission]
GO
/****** Object:  Table [dbo].[NLog]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[NLog]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[Menu]
GO
/****** Object:  Table [dbo].[ManagerRole]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[ManagerRole]
GO
/****** Object:  Table [dbo].[ManagerLog]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[ManagerLog]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[Manager]
GO
/****** Object:  Table [dbo].[ArticleCategory]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[ArticleCategory]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 2019/3/20 14:54:18 ******/
DROP TABLE [dbo].[Article]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Title] [varchar](128) NOT NULL,
	[ImageUrl] [varchar](128) NULL,
	[Content] [text] NULL,
	[ViewCount] [int] NOT NULL,
	[Sort] [int] NOT NULL,
	[Author] [varchar](64) NULL,
	[Source] [varchar](128) NULL,
	[SeoTitle] [varchar](128) NULL,
	[SeoKeyword] [varchar](256) NULL,
	[SeoDescription] [varchar](512) NULL,
	[AddManagerId] [int] NOT NULL,
	[AddTime] [datetime] NOT NULL,
	[ModifyManagerId] [int] NULL,
	[ModifyTime] [datetime] NULL,
	[IsTop] [bit] NOT NULL,
	[IsSlide] [bit] NOT NULL,
	[IsRed] [bit] NOT NULL,
	[IsPublish] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticleCategory]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticleCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](128) NOT NULL,
	[ParentId] [int] NOT NULL,
	[ClassList] [varchar](128) NULL,
	[ClassLayer] [int] NULL,
	[Sort] [int] NOT NULL,
	[ImageUrl] [varchar](128) NULL,
	[SeoTitle] [varchar](128) NULL,
	[SeoKeywords] [varchar](256) NULL,
	[SeoDescription] [varchar](512) NULL,
	[IsDeleted] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserName] [varchar](32) NOT NULL,
	[Password] [varchar](128) NOT NULL,
	[Avatar] [varchar](256) NULL,
	[NickName] [varchar](32) NULL,
	[Mobile] [varchar](16) NULL,
	[Email] [varchar](128) NULL,
	[LoginCount] [int] NULL,
	[LoginLastIp] [varchar](64) NULL,
	[LoginLastTime] [datetime] NULL,
	[AddManagerId] [int] NOT NULL,
	[AddTime] [datetime] NOT NULL,
	[ModifyManagerId] [int] NULL,
	[ModifyTime] [datetime] NULL,
	[IsLock] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[Remark] [varchar](128) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerLog]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ActionType] [varchar](32) NULL,
	[AddManageId] [int] NOT NULL,
	[AddManagerNickName] [varchar](64) NULL,
	[AddTime] [datetime] NOT NULL,
	[AddIp] [varchar](64) NULL,
	[Remark] [varchar](256) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerRole]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](64) NOT NULL,
	[RoleType] [int] NOT NULL,
	[IsSystem] [bit] NOT NULL,
	[AddManagerId] [int] NOT NULL,
	[AddTime] [datetime] NOT NULL,
	[ModifyManagerId] [int] NULL,
	[ModifyTime] [datetime] NULL,
	[IsDelete] [bit] NOT NULL,
	[Remark] [varchar](128) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[Name] [varchar](32) NOT NULL,
	[DisplayName] [varchar](128) NULL,
	[IconUrl] [varchar](128) NULL,
	[LinkUrl] [varchar](128) NULL,
	[Sort] [int] NULL,
	[Permission] [varchar](256) NULL,
	[IsDisplay] [bit] NOT NULL,
	[IsSystem] [bit] NOT NULL,
	[AddManagerId] [int] NOT NULL,
	[AddTime] [datetime] NOT NULL,
	[ModifyManagerId] [int] NULL,
	[ModifyTime] [datetime] NULL,
	[IsDelete] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NLog]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Application] [nvarchar](50) NULL,
	[Logged] [datetime] NULL,
	[Level] [nvarchar](50) NULL,
	[Message] [nvarchar](max) NULL,
	[Logger] [nvarchar](250) NULL,
	[Callsite] [nvarchar](512) NULL,
	[Exception] [nvarchar](max) NULL,
 CONSTRAINT [PK_NLOG] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermission]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
	[Permission] [varchar](128) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskInfo]    Script Date: 2019/3/20 14:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](128) NOT NULL,
	[Group] [varchar](128) NOT NULL,
	[Description] [varchar](256) NULL,
	[Assembly] [varchar](256) NOT NULL,
	[ClassName] [varchar](256) NOT NULL,
	[Status] [int] NOT NULL,
	[Cron] [varchar](128) NOT NULL,
	[AddTime] [datetime] NULL,
	[AddManagerId] [int] NOT NULL,
 CONSTRAINT [PK_TASKINFO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([Id], [RoleId], [UserName], [Password], [Avatar], [NickName], [Mobile], [Email], [LoginCount], [LoginLastIp], [LoginLastTime], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsLock], [IsDelete], [Remark]) VALUES (3, 1, N'admin', N'AGq/ucAkhJvACA0qOnHS8A==', N'/upload/20190312/201903122159059093173.jpg', N'超级管理员', N'17730213419', N'1015657114@qq.com', 55, N'::1', CAST(N'2019-03-20T11:17:23.423' AS DateTime), 1, CAST(N'2019-01-01T21:46:18.557' AS DateTime), 3, CAST(N'2019-03-12T21:59:07.737' AS DateTime), 0, 0, N'超级管理员,系统只能有一个这样的用户')
SET IDENTITY_INSERT [dbo].[Manager] OFF
SET IDENTITY_INSERT [dbo].[ManagerLog] ON 

INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-23T12:55:36.307' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (2, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-23T14:09:00.933' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (3, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-23T15:53:57.433' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (4, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-24T22:57:19.250' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (5, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-25T10:11:16.543' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (6, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-25T10:30:54.277' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (8, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-28T22:10:42.000' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (9, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-28T22:40:32.997' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (10, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T12:34:19.940' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (11, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T13:30:56.953' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (12, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T13:35:04.343' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (13, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T13:39:10.247' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (14, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T14:27:33.897' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (15, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T14:57:51.820' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (16, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T16:00:19.983' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (17, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T16:01:17.193' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (18, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T16:41:36.153' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (19, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T17:22:48.397' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (20, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T17:41:35.090' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (21, N'SignIn', 3, N'超级管理员', CAST(N'2019-02-18T18:48:45.793' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (22, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-05T21:57:33.547' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (23, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-05T22:30:22.397' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1022, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T11:58:54.817' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1023, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T12:39:32.060' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1024, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T13:22:14.103' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1025, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T14:42:37.153' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1026, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T14:58:32.130' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1027, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T15:35:05.457' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1028, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T15:51:10.527' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1029, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T16:15:25.527' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1030, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T16:43:05.427' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1031, N'SignIn', 3, N'超级1管理员', CAST(N'2019-03-12T20:41:28.770' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1032, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T21:43:41.877' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1033, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-12T21:48:10.543' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1034, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-13T12:36:31.397' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1035, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-13T15:15:33.770' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1038, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-13T21:23:27.183' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1039, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-14T09:59:29.237' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1041, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-14T11:44:13.440' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1042, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-14T12:27:52.657' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1043, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-15T16:37:15.663' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1044, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-15T16:47:46.353' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1045, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-15T21:43:34.983' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1046, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-15T22:05:19.927' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1047, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-18T14:53:54.537' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1048, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-18T17:20:23.613' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1049, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-18T17:49:04.407' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1050, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-18T18:25:41.900' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1051, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-18T19:11:29.683' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1052, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-20T10:58:54.833' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1053, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-20T11:17:23.440' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (7, N'SignIn', 3, N'超级管理员', CAST(N'2019-01-25T13:18:55.490' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1036, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-13T17:05:52.147' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1037, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-13T17:25:25.967' AS DateTime), N'::1', N'用户登录')
INSERT [dbo].[ManagerLog] ([Id], [ActionType], [AddManageId], [AddManagerNickName], [AddTime], [AddIp], [Remark]) VALUES (1040, N'SignIn', 3, N'超级管理员', CAST(N'2019-03-14T11:23:16.200' AS DateTime), N'::1', N'用户登录')
SET IDENTITY_INSERT [dbo].[ManagerLog] OFF
SET IDENTITY_INSERT [dbo].[ManagerRole] ON 

INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (1, N'超级管理员', 1, 0, 1, CAST(N'2018-12-30T15:53:59.957' AS DateTime), 1, CAST(N'2019-03-13T12:37:48.643' AS DateTime), 0, N'超级管理员，拥有系统最高权限，Bug般的存在')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (2, N'系统管理员', 2, 1, 1, CAST(N'2018-12-30T16:22:03.670' AS DateTime), NULL, NULL, 0, N'系统管理员，顾名思义CMS系统的管理员，可以对系统管理员进行相关权限的个性化配置')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (3, N'编辑', 2, 0, 1, CAST(N'2018-12-30T19:40:34.363' AS DateTime), 1, CAST(N'2018-12-30T21:53:02.787' AS DateTime), 0, N'拥有文章内容编辑权限')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (4, N'编辑2', 2, 0, 1, CAST(N'2018-12-30T19:44:06.670' AS DateTime), 1, CAST(N'2018-12-31T17:06:46.713' AS DateTime), 0, N'编辑2')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (8, N'编辑6', 2, 0, 1, CAST(N'2018-12-30T19:51:28.067' AS DateTime), NULL, NULL, 0, N'编辑6')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (11, N'编辑9', 2, 0, 1, CAST(N'2018-12-30T20:36:43.080' AS DateTime), 1, CAST(N'2018-12-30T21:52:15.520' AS DateTime), 0, N'编辑9')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (12, N'编辑10', 2, 0, 1, CAST(N'2018-12-30T23:05:04.340' AS DateTime), NULL, NULL, 0, N'编辑10')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (15, N'编辑11', 2, 0, 1, CAST(N'2019-01-16T15:02:06.717' AS DateTime), 1, CAST(N'2019-01-17T22:43:11.273' AS DateTime), 0, N'编辑11')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (5, N'编辑3', 2, 0, 1, CAST(N'2018-12-30T19:47:07.513' AS DateTime), 1, CAST(N'2018-12-30T21:52:53.013' AS DateTime), 0, N'编辑3')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (6, N'编辑4', 2, 0, 1, CAST(N'2018-12-30T19:48:37.447' AS DateTime), NULL, NULL, 0, N'编辑4')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (9, N'编辑7', 2, 0, 1, CAST(N'2018-12-30T19:53:25.263' AS DateTime), 1, CAST(N'2018-12-30T21:52:30.210' AS DateTime), 0, N'编辑7')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (10, N'编辑8', 2, 0, 1, CAST(N'2018-12-30T19:57:25.350' AS DateTime), NULL, NULL, 0, N'编辑8')
INSERT [dbo].[ManagerRole] ([Id], [RoleName], [RoleType], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete], [Remark]) VALUES (7, N'编辑5', 2, 0, 1, CAST(N'2018-12-30T19:50:01.297' AS DateTime), 1, CAST(N'2018-12-31T12:39:19.817' AS DateTime), 0, N'编辑5')
SET IDENTITY_INSERT [dbo].[ManagerRole] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (6, 0, N'system_setting', N'系统管理', N'&#xe620;', NULL, 99, NULL, 1, 1, 1, CAST(N'2019-01-05T18:45:02.033' AS DateTime), 1, CAST(N'2019-01-08T14:14:29.400' AS DateTime), 0)
INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (7, 0, N'content_manage', N'内容管理', N'&#xe63c;', NULL, 99, NULL, 1, 1, 1, CAST(N'2019-01-05T18:46:26.027' AS DateTime), 1, CAST(N'2019-01-08T14:13:08.183' AS DateTime), 0)
INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (1006, 6, N'user_manage', N'用户管理', N'&#xe612;', N'/Manager/Index', 99, NULL, 1, 1, 1, CAST(N'2019-01-08T14:12:28.487' AS DateTime), 1, CAST(N'2019-01-09T22:23:02.020' AS DateTime), 0)
INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (1007, 6, N'role_manager', N'角色管理', N'icon-vip', N'/ManagerRole/Index', 99, NULL, 1, 1, 1, CAST(N'2019-01-08T14:18:31.633' AS DateTime), 1, CAST(N'2019-01-09T22:22:54.590' AS DateTime), 0)
INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (1008, 6, N'menu_manager', N'菜单管理', N'icon-caidan', N'/Menu/Index', 99, NULL, 1, 1, 1, CAST(N'2019-01-08T14:19:13.537' AS DateTime), 1, CAST(N'2019-01-28T22:22:50.710' AS DateTime), 0)
INSERT [dbo].[Menu] ([Id], [ParentId], [Name], [DisplayName], [IconUrl], [LinkUrl], [Sort], [Permission], [IsDisplay], [IsSystem], [AddManagerId], [AddTime], [ModifyManagerId], [ModifyTime], [IsDelete]) VALUES (1009, 6, N'task_info', N'任务管理', N'&#xe620;', N'/TaskInfo/Index', 99, NULL, 1, 1, 1, CAST(N'2019-03-13T12:37:23.173' AS DateTime), 1, CAST(N'2019-03-13T12:37:36.740' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[RolePermission] ON 

INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (14, 15, 6, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (15, 15, 1006, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (16, 15, 1007, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (17, 15, 1008, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (18, 15, 7, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1020, 1, 6, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1021, 1, 1006, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1022, 1, 1007, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1023, 1, 1008, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1024, 1, 1009, N'')
INSERT [dbo].[RolePermission] ([Id], [RoleId], [MenuId], [Permission]) VALUES (1025, 1, 7, N'')
SET IDENTITY_INSERT [dbo].[RolePermission] OFF
SET IDENTITY_INSERT [dbo].[TaskInfo] ON 

INSERT [dbo].[TaskInfo] ([Id], [Name], [Group], [Description], [Assembly], [ClassName], [Status], [Cron], [AddTime], [AddManagerId]) VALUES (5, N'LogTestJob', N'TestGroup', N'测试Log', N'E:\workspace\vs2017\Czar.Cms\src\Czar.Cms.Admin\bin\Debug\netcoreapp2.2\Czar.Cms.Job.dll', N'Czar.Cms.Job.LogTestJob', 2, N'*/5 * * * * ?', CAST(N'2019-03-18T19:28:05.020' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[TaskInfo] OFF
/****** Object:  Index [PK_ARTICLE]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Article] ADD  CONSTRAINT [PK_ARTICLE] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ARTICLECATEGORY]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ArticleCategory] ADD  CONSTRAINT [PK_ARTICLECATEGORY] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_MANAGER]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Manager] ADD  CONSTRAINT [PK_MANAGER] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_MANAGERLOG]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ManagerLog] ADD  CONSTRAINT [PK_MANAGERLOG] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_MANAGERROLE]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[ManagerRole] ADD  CONSTRAINT [PK_MANAGERROLE] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_MENU]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [PK_MENU] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ROLEPERMISSION]    Script Date: 2019/3/20 14:54:18 ******/
ALTER TABLE [dbo].[RolePermission] ADD  CONSTRAINT [PK_ROLEPERMISSION] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT ((0)) FOR [IsTop]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT ((0)) FOR [IsSlide]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT ((0)) FOR [IsRed]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT ((0)) FOR [IsPublish]
GO
ALTER TABLE [dbo].[Article] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ArticleCategory] ADD  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Manager] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
ALTER TABLE [dbo].[Manager] ADD  DEFAULT ((0)) FOR [IsLock]
GO
ALTER TABLE [dbo].[Manager] ADD  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[ManagerLog] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
ALTER TABLE [dbo].[ManagerRole] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_Sort]  DEFAULT ((0)) FOR [Sort]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_IsDisplay]  DEFAULT ((1)) FOR [IsDisplay]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_IsSystem]  DEFAULT ((0)) FOR [IsSystem]
GO
ALTER TABLE [dbo].[Menu] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_ARTICLE_RELATIONS_ARTICLEC] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ArticleCategory] ([Id])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_ARTICLE_RELATIONS_ARTICLEC]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_MANAGER_RELATIONS_MANAGERR] FOREIGN KEY([RoleId])
REFERENCES [dbo].[ManagerRole] ([Id])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_MANAGER_RELATIONS_MANAGERR]
GO
ALTER TABLE [dbo].[ManagerLog]  WITH CHECK ADD  CONSTRAINT [FK_MANAGERL_RELATIONS_MANAGER] FOREIGN KEY([AddManageId])
REFERENCES [dbo].[Manager] ([Id])
GO
ALTER TABLE [dbo].[ManagerLog] CHECK CONSTRAINT [FK_MANAGERL_RELATIONS_MANAGER]
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_ROLEPERM_RELATIONS_MANAGERR] FOREIGN KEY([RoleId])
REFERENCES [dbo].[ManagerRole] ([Id])
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_ROLEPERM_RELATIONS_MANAGERR]
GO
ALTER TABLE [dbo].[RolePermission]  WITH CHECK ADD  CONSTRAINT [FK_ROLEPERM_RELATIONS_MENU] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu] ([Id])
GO
ALTER TABLE [dbo].[RolePermission] CHECK CONSTRAINT [FK_ROLEPERM_RELATIONS_MENU]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文章标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ImageUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文章内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'浏览次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ViewCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'Source'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoKeyword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SEO描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否置顶' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsTop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否轮播显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsSlide'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否热门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsRed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否发布' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsPublish'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文章' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Article'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父分类ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类别ID列表(逗号分隔开)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ClassList'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'类别深度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ClassLayer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类图标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'ImageUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类SEO标题' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类SEO关键字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoKeywords'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类SEO描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'SeoDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文章分类' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ArticleCategory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Avatar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户昵称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'NickName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮箱地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后一次登录IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginLastIp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后一次登录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'LoginLastTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否锁定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'IsLock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'后台管理员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Manager'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'ActionType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddManageId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作人名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddManagerNickName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'AddIp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作日志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerLog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色类型1超管2系管' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'RoleType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否系统默认' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'后台管理员角色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ManagerRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'显示名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'DisplayName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图标地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IconUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'链接地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'LinkUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序数字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作权限（按钮权限时使用）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'Permission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsDisplay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否系统默认' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsSystem'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'AddManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'AddTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ModifyManagerId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'后台管理菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'RoleId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作类型（功能权限）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission', @level2type=N'COLUMN',@level2name=N'Permission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RolePermission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'定时任务' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TaskInfo'
GO