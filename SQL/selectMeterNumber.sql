SELECT stationid,userid, MeterQcPoint.meterId, MeterNumber, userID, qcPointPass, qcPointPassDate, qcPointPass
  FROM [Aqualoc].[dbo].[MeterQcPoint] Inner join meters on MeterQcPoint.meterId = meters.MeterID
  
 Select MeterQcPointID From meterQCPoint where meterNumber = '10000000'