/* Price High To Low*/
SELECT * 
FROM project.powertools
order by Price DESC;

/*Ratings*/
select * 
from powertools
/* Where ProductId = ''*/
order by Rating Desc;

/*Saving */
select ProductId,SavingsPercentage
from powertools;
/*Where productId =''*/

/*Brand*/
Select ProductId,Brand	
from powertools;
/*Where productId =''*/

/*Vendor*/
Select ProductId,VendorName	
from powertools;
/*Where productId =''*/

/*Quantity Avaliable*/
Select ProductId,quantity	
from powertools;
/*Where productId =''*/

/*Vendors Quantity */
Select ProductId,VendorQuantity	
from powertools;
/*Where productId =''*/


/*Sort By Name Asc*/
Select * 
from  powertools
order by ProductName Asc;

/*Sort By Name Desc*/
Select * 
from  powertools
order by ProductName DESC;