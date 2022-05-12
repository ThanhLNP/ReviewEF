DELETE FROM "Employees";
DELETE FROM "AssetTypes";
DELETE FROM "ITAssets";
DELETE FROM "ITAssetInventories";
DELETE FROM "EmployeeAssets";

INSERT INTO "Employees"
  ("Id","FirstName","LastName","Department","Extension","Email","OtherDetails","CreateDate","ModifiedDate","IsDeleted")
VALUES
  (1,'Carson','Alexander','test03','','Carson@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (2,'Meredith','Alonso','test04','','Meredith@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (3,'Arturo','Anand','test05','','Arturo@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (4,'Gytis','Barzdukas','test01','','Gytis@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (5,'Yan','Li','test02','','Yan@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (6,'Peggy','Justice','test03','','Peggy@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (7,'Laura','Norman','test03','','Laura@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (8,'Nino','Olivetto','test05','','Nino@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (9,'test01','test01','test01','','test01@gmail.com','',DEFAULT,DEFAULT,DEFAULT),
  (10,'test02','test02','test02','','test02@gmail.com','',DEFAULT,DEFAULT,DEFAULT);

INSERT INTO "AssetTypes"
  ("Code","Description","CreateDate","ModifiedDate","IsDeleted")
VALUES
  ('FWGD','eleifend mi in',DEFAULT,DEFAULT,DEFAULT),
  ('SWFW','non tellus orci ac ',DEFAULT,DEFAULT,DEFAULT),
  ('BDRM','purus in mollis',DEFAULT,DEFAULT,DEFAULT),
  ('FGQS','dolore magna aliqua',DEFAULT,DEFAULT,DEFAULT),
  ('3G4G','malesuada fames',DEFAULT,DEFAULT,DEFAULT);

INSERT INTO "ITAssets"
  ("Id","AssetTypeCode","Description","OtherDetais","CreateDate","ModifiedDate","IsDeleted")
VALUES
  (1,'FWGD','Lorem ipsum dolor sit amet','',DEFAULT,DEFAULT,DEFAULT),
  (2,'SWFW','ea commodo consequat','',DEFAULT,DEFAULT,DEFAULT),
  (3,'3G4G','officia deserunt mollit anim','',DEFAULT,DEFAULT,DEFAULT),
  (4,'BDRM','nulla pariatur','',DEFAULT,DEFAULT,DEFAULT),
  (5,'FGQS','Duis aute irure','',DEFAULT,DEFAULT,DEFAULT),
  (6,'FGQS','quis nostrud exercitation','',DEFAULT,DEFAULT,DEFAULT),
  (7,'FGQS','in reprehenderit in','',DEFAULT,DEFAULT,DEFAULT),
  (8,'FWGD','velit esse cillum','',DEFAULT,DEFAULT,DEFAULT),
  (9,'SWFW','fugiat nulla','',DEFAULT,DEFAULT,DEFAULT),
  (10,'SWFW','sed do','',DEFAULT,DEFAULT,DEFAULT);

INSERT INTO "ITAssetInventories"
  ("Id","AssetId","InventoryDate","NumberAssigned","NumberInStock","OtherDetails","CreateDate","ModifiedDate","IsDeleted")
VALUES
  (1,2,'2021-06-03',3,6,'',DEFAULT,DEFAULT,DEFAULT),
  (2,1,'2021-08-05',7,7,'',DEFAULT,DEFAULT,DEFAULT),
  (3,1,'2021-08-11',2,8,'',DEFAULT,DEFAULT,DEFAULT),
  (4,3,'2021-10-04',6,9,'',DEFAULT,DEFAULT,DEFAULT),
  (5,4,'2021-10-03',3,8,'',DEFAULT,DEFAULT,DEFAULT),
  (6,1,'2021-10-12',2,8,'',DEFAULT,DEFAULT,DEFAULT),
  (7,6,'2021-10-06',2,8,'',DEFAULT,DEFAULT,DEFAULT),
  (8,7,'2021-11-04',6,10,'',DEFAULT,DEFAULT,DEFAULT),
  (9,8,'2021-11-04',3,6,'',DEFAULT,DEFAULT,DEFAULT),
  (10,9,'2021-12-23',2,8,'',DEFAULT,DEFAULT,DEFAULT);

INSERT INTO "EmployeeAssets"
  ("Id","AssetId","EmployeeId","DateOut","DateReturned","ConditionOut","ConditionReturned","OtherDetails","CreateDate","ModifiedDate","IsDeleted")
VALUES
  (1,1,9,'2021-12-26',NULL,'Maecenas sed enim',' lorem','Auctor elit sed',DEFAULT,DEFAULT,DEFAULT),
  (2,2,4,'2021-12-08','2022-09-06','morbi enim nunc faucibus','habitasse platea','',DEFAULT,DEFAULT,DEFAULT),
  (3,3,6,'2021-09-20',NULL,'porttitor massa id neque','diam ut venenatis','',DEFAULT,DEFAULT,DEFAULT),
  (4,4,7,'2021-11-24','2022-11-10','elementum tempus','Viverra nibh','',DEFAULT,DEFAULT,DEFAULT),
  (5,10,1,'2021-12-29',NULL,' fermentum iaculis','Tristique magna','lacinia at',DEFAULT,DEFAULT,DEFAULT);
