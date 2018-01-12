UPDATE [FengestDB].[dbo].[NOESIS_UPDATE_CENTER]
   SET 
      [DB_VERSION] = '3.7.0.0'
      ,[SOFTWARE_VERSION] = '6.5.0.0'
      ,[LAST_UPDATE] = getDate()
      ,[DB_UPDATE_PATH] = ''
      ,[SOFTWARE_UPDATE_PATH] = ''
 WHERE id = 1