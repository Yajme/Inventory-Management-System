

# Inventory Management System Using C#<br>
 
## Chapter 1: Concept
Mind map:<br>
 ![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/120c8213-9d92-4462-97c5-ce7662b8d540)

Flowchart:<br>
  ![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/438efc02-acbb-41fe-af33-ac3cf0f9b56a)
<br>
### I.	Inventory Tracking
a.	Inventory Database<br>
Create and manage a database to store inventory information, including product details, quantities, and locations.<br>

b.	Barcode scanning<br>
Implement barcode scanning functionality to update inventory levels and track product movements quickly and accurately.<br>

c.	Stock alerts<br>
Set up alerts and notifications to inform users when inventory levels are running low or when items are out of stock.
### II.	Order Management
#### a.	Order Placement
Enable users to place orders for products, including features like selecting items, specifying quantities, and choosing shipping options.
i.	Order Processing: Process incoming orders, update inventory levels , update sales database , and generate invoices .
#### b.	Inventory Replenishment
<br>
i.	Reorder Trigger : Automatically detect when inventory levels reach a predefined threshold, triggering the need to replenish stock.<br>
ii.	Generate Purchase Order : Create purchase orders based on the reorder trigger and send them to suppliers .<br>
iii.	Receive Order Confirmation : Receive confirmation from suppliers regarding the purchase order and update inventory and purchase database .<br>

c.	Return and Exchanges
Return Authorization : Manage the process of authorizing returns and exchanges, update inventory , and update sales database . Generate refunds when necessary.
### III.	Reporting and Analytics
a. Inventory Reports<br>
Generate reports providing insights into inventory levels , stock movements , and expiry tracking .<br>
b.	Sales Reports<br>
Generate reports on sales performance, including overall sales performance, product sales, and customer sales.<br>
c.	Purchase Reports<br>
Generate reports on purchasing activities, including supplier performance, product purchases, and cost analysis.<br>
 <br><br>
## Chapter 2: Planning
### I.	Requirement Gathering
a.	Introduction: 
<br>Traditional inventory system using papers and manual labor has been used by many vendors here in the Philippines to track the store inventory and calculate their sales. Some are also using excel to efficiently calculate and track their sales however it is most efficient to use software that automatically track sales and inventory that is stored in a database that can be used in a long term and adequately boost productivity in sales. <br>
b.	Scopes and Objectives: <br>
The Inventory Management System will be:<br>
-	providing its services to a small grocery store to handle transactions and concurrencies within the business to effectively track sales and manage inventory proficiently.
-	handling products that are within the store but may vary according to the availability to the suppliers.
-	supporting multi-user mode to administer functions according to the position of the employee.<br>
<br>
The Inventory Management System aims to:<br>
-	Ensure accurate tracking of inventory levels, including real-time updates and stock adjustments.
-	Streamline the order management process, from placing orders to order processing and fulfillment.
-	Generate comprehensive reports on inventory status, sales performance, and purchasing activities.
-	Implement barcode scanning functionality for efficient inventory management and product identification.
-	Set up stock alerts and notifications to prevent stockouts and optimize inventory replenishment.
-	Enable returns and exchanges management, including authorization, inventory updates, and refunds.
<br>
c.	Features<br>

1.	Inventory Tracking Features:
-	Ability to add, update, and delete inventory items.
-	Real-time tracking of inventory levels and availability.
- Assigning unique identifiers (e.g., SKU, serial numbers) to items.
-	Recording purchase and sales transactions for accurate inventory management.
2.	Order Management Features:
-	Order placement functionality for cashiers.
-	Managing returns, exchanges, and refunds.


3.	Reporting and Analytics Features:
-	Generation of inventory reports, such as stock levels, stock movements, and expiry tracking.
-	Sales reports, including revenue, product sales, and customer sales analysis.
-	Purchase reports, such as supplier performance, purchase history, and cost analysis.
-	Customizable report generation based on user-defined parameters.
-	Visualization of data through charts, graphs, and dashboards for easy analysis.
4.	Barcode Scanning and Integration Features:
-	Barcode scanning functionality to quickly identify and update inventory items.
- Integration with barcode scanners or mobile devices for seamless scanning.
-	Automatic inventory updates upon scanning and data validation.
-	Integration with barcode databases or product catalogs for quick product information retrieval.
5.	Stock Alerts and Notifications Features:
-	Set up automated stock alerts when inventory levels reach predefined thresholds.
-	Notifications via email, SMS, or dashboard alerts for low stock or stockout situations.
-	Configurable alert preferences and escalation procedures.
-	Integration with inventory replenishment processes to trigger reorder actions.

### II.	System Design
The Inventory Management System Interface will be designed using Visual Studio to create user-friendly experience and suitable environment for the user. 

### III.	Database Development

### IV.	Backend Development

### V.	User interface development

### VI.	Integration and Testing

### VII.	Security and Access Control

### VIII.	Deployment and Maintenance


