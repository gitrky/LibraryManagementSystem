Select TOP 1 TBL_PUBLISHER.NAME , COUNT(*) FROM TBL_BOOK 
INNER JOIN TBL_PUBLISHER ON TBL_PUBLISHER.ID = TBL_BOOK.PUBLISHERID
GROUP BY TBL_PUBLISHER.NAME ORDER BY COUNT(*) DESC