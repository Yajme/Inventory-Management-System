

# Inventory Management System Using C#<br>
 
## Chapter 1: Concept
### Mind map:<br>
![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/494ec97e-b1d5-4357-842f-72307511e50a)


### Flowchart:<br>

  ![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/438efc02-acbb-41fe-af33-ac3cf0f9b56a)
  
  
<br>

###  I.	Inventory Tracking 
***
a.	Inventory Database  <br>

> Create and manage a database to store inventory information, including product details, quantities, and locations.<br>

b.	Barcode scanning<br>

> Implement barcode scanning functionality to update inventory levels and track product movements quickly and accurately.<br>

c.	Stock alerts<br>

> Set up alerts and notifications to inform users when inventory levels are running low or when items are out of stock.

### II.	Order Management
***
#### a.	Order Placement
> Enable users to place orders for products, including features like selecting items, specifying quantities, and choosing shipping options.
>> Order Processing: Process incoming orders, update inventory levels, update sales database, and generate invoices.


#### b.	Inventory Replenishment
<br>

> i.	Reorder Trigger : Automatically detect when inventory levels reach a predefined threshold, triggering the need to replenish stock.


> ii.	Generate Purchase Order : Create purchase orders based on the reorder trigger and send them to suppliers.


> iii.	Receive Order Confirmation : Receive confirmation from suppliers regarding the purchase order and update inventory and purchase database.



c.	Return and Exchanges
> Return Authorization : Manage the process of authorizing returns and exchanges, update inventory, and update sales database. Generate refunds when necessary.
### III.	Reporting and Analytics
***
a. Inventory Reports<br>
> Generate reports providing insights into inventory levels , stock movements , and expiry tracking .<br>


b.	Sales Reports<br>

> Generate reports on sales performance, including overall sales performance, product sales, and customer sales.<br>


c.	Purchase Reports<br>
> Generate reports on purchasing activities, including supplier performance, product purchases, and cost analysis.<br>


 <br><br>
## Chapter 2: Planning
### I.	Requirement Gathering
***
#### a.	Introduction: 
<br>Traditional inventory system using papers and manual labor has been used by many vendors here in the Philippines to track the store inventory and calculate their sales. Some are also using excel to efficiently calculate and track their sales however it is most efficient to use software that automatically track sales and inventory that is stored in a database that can be used in a long term and adequately boost productivity in sales. <br>
#### b.	Scopes and Objectives: <br>
The Inventory Management System will be:<br>
-	providing its services to a small grocery store to handle transactions and concurrencies within the business to effectively track sales and manage inventory proficiently.
-	handling products that are within the store but may vary according to the availability to the suppliers.
-	supporting multi-user mode to administer functions according to the position of the employee.<br>
<br>
The Inventory Management System aims to: <br><br>


- Ensure accurate tracking of inventory levels, including real-time updates and stock adjustments.
- Streamline the order management process, from placing orders to order processing and fulfillment.
- Generate comprehensive reports on inventory status, sales performance, and purchasing activities.
- Implement barcode scanning functionality for efficient inventory management and product identification.
- Set up stock alerts and notifications to prevent stockouts and optimize inventory replenishment.
- Enable returns and exchanges management, including authorization, inventory updates, and refunds.
<br>

#### c.	Features <br>

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
***
<p>The user interface of the Inventory Management System will be designed using Visual Studio, aiming to deliver a user-friendly experience and create an environment that maximizes efficiency while ensuring accurate sales reports and inventory tracking. This approach will minimize user effort and enhance overall system usability. Additionally, the system will be developed using the C# programming language.

 </p>
 
### III.	Database Development
***

<p> The project will be using a database to store important information such as orders, invoices, customer details, and inventory data. This will create a central and well-organized place to manage and access data efficiently. The database allows different parts of the system to work together smoothly and enables accurate tracking, reporting, and analysis of inventory-related activities. By using a database, the Inventory Management System can easily store, update, and retrieve necessary information, improving the overall functionality and dependability of the system. </p>

<br>

  a. The Entity Relationship Diagram illustrates the connections between different entities within the system and outlines the roles and functions of each entity within those relationships.
  
  <br>
  
  ![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/5e8c60a9-23c5-4197-900a-18dfbfb8ef38)
*Figure 1. Sample ER Diagram*
<br>


- The table named "Products" holds information pertaining to products, including their identification number, name, description, category, supplier, unit price, stock quantity, and reorder level. 
- The "Categories" table maintains a record of different product categories, while the "Suppliers" table contains details about suppliers, such as their identification number, name, contact person, phone number, and email address. 
- The "Orders" table keeps track of customer orders and includes fields for order identification number, order date, and customer identification number.
- The "OrderItems" table records individual items within an order, including their order item identification number, order identification number, product identification number, quantity, and unit price.
- The "Customers" table stores customer information such as customer identification number, name, address, city, phone number, and email address. 
- The "Warehouses" table maintains information about warehouses, including their identification number, name, and location. 
- Lastly, the "StockMovements" table tracks the movement of inventory between warehouses and includes fields for movement identification number, product identification number, warehouse identification number, type of movement, date of movement, and quantity. 
 
 <br>
 
 Altogether, these tables create a comprehensive database structure that enables efficient storage, retrieval, and management of data related to inventory within the Inventory Management System. 

<br>
b.	Database Engine

<br>

This project will be using MS SQL Server as the Database Engine for several reasons:
<br>
<br>
i.	Robust and Reliable: MS SQL is known for its stability, reliability, and performance. It is designed to handle large volumes of data and high transaction loads, making it suitable for enterprise-level applications.<br><br>
ii.	Comprehensive Feature Set: MS SQL offers a wide range of features, including advanced querying capabilities, indexing options, stored procedures, triggers, and support for complex data types. It also provides built-in support for full-text search, data encryption, and high availability solutions.<br><br>
iii.	Integration with Microsoft Ecosystem: If you are already utilizing other Microsoft technologies such as .NET framework, Azure cloud services, or Windows Server, MS SQL integrates seamlessly with these platforms. This integration can simplify development, deployment, and management processes.<br><br>
iv.	Scalability and Performance: MS SQL provides various features to optimize and scale your database as your application grows. It supports clustering, replication, partitioning, and distributed query processing, allowing you to handle increasing workloads and ensure optimal performance.<br><br>
v.	Security Features: Security is a critical aspect of any database system. MS SQL offers robust security features such as role-based access control, transparent data encryption, and fine-grained auditing. It also provides features like row-level security and dynamic data masking to protect sensitive data.<br><br>
vi.	Management Tools: Microsoft provides powerful management tools like SQL Server Management Studio (SSMS) and Azure Data Studio, which offer intuitive interfaces for database administration, performance tuning, monitoring, and troubleshooting.<br><br>
vii.	Strong Community and Support: MS SQL has a large and active community of developers and database administrators. This means there are ample resources, tutorials, forums, and documentation available to assist with any challenges you may face.<br><br>

### IV.	Backend Development
***
<p>This project aims to develop the Inventory Management System using C# programming language within the .NET Framework. C# is widely recognized for its flexibility and reliability, offering a vast array of features and libraries that will expedite development and seamless integration with other technologies.

The development process will prioritize the creation of a modular and scalable architecture capable of handling diverse aspects of inventory management, including stock level tracking, supplier management, and order processing. Leveraging the extensive toolset and frameworks provided by the .NET Framework, particularly .NET Core, will allow for efficient development and deployment across multiple platforms.

To ensure the smooth management of data, the system will employ a reliable database management system like Microsoft SQL Server. This will enable efficient storage and retrieval of inventory-related information, ensuring prompt and accurate access to inventory data through efficient querying and manipulation techniques.
</p>

### V.	User interface development
***

<p>The system will incorporate user-friendly interfaces, allowing authorized users to easily navigate through different functionalities and perform tasks efficiently. The graphical user interface (GUI) will be designed using modern UI frameworks, such as Windows Presentation Foundation (WPF) or ASP.NET, to provide a visually appealing and intuitive user experience.
To enhance the system's functionality and performance, various libraries and frameworks within the .NET ecosystem will be leveraged. This includes leveraging third-party libraries for barcode scanning and generation, reporting and analytics, and integration with external systems such as payment gateways or enterprise resource planning (ERP) systems.
 </p>
   
### VI.	Integration and Testing
***


<p>Integration and testing play a critical role in the development of an Inventory Management System. Integration involves merging the backend functionality with the user interface to ensure a seamless connection between different system components. This ensures that user actions are processed correctly, and data flows smoothly throughout the system. Integration testing validates the communication channels between components, ensuring they function as expected and exchange data accurately. Additionally, rigorous testing is conducted to evaluate the system's accuracy, reliability, and performance. This helps identify and rectify any bugs, errors, or performance issues encountered during testing. By addressing these issues proactively, developers can ensure that the Inventory Management System operates smoothly, provides reliable results, and performs optimally in real-world scenarios. Through effective integration and comprehensive testing, the system can deliver the desired level of functionality, stability, and usability to meet the requirements of the users and the organization. </p>

### VII.	Security and Access Control
***

<p>Security and access control are essential considerations in the development of an Inventory Management System. Implementing appropriate security measures is crucial to protect sensitive inventory data from unauthorized access and potential breaches. This involves employing techniques such as data encryption, secure storage, and regular backups to ensure the confidentiality and integrity of the data. Additionally, implementing authentication and authorization mechanisms enables the system to control user access and permissions effectively. By verifying user identities and assigning appropriate roles and permissions, the system ensures that only authorized individuals can access specific data and perform authorized actions. Furthermore, considering the implementation of encryption and secure protocols for data transmission enhances the system's security during communication. This prevents unauthorized interception and ensures that data remains protected while in transit. By prioritizing security and access control, the Inventory Management System can maintain the confidentiality, integrity, and availability of inventory data, mitigating the risks associated with data breaches and unauthorized access. This instills confidence in users and protects the sensitive information critical to the organization's operations. </p>

### VIII.	Deployment and Maintenance
***

<p>Deployment and maintenance are critical stages in the lifecycle of an Inventory Management System. Once the system has been developed, it needs to be deployed to the production environment to make it accessible to users. This involves setting up the necessary infrastructure, including hosting services, server configurations, and dependencies, to ensure smooth operation. Once deployed, regular maintenance procedures are essential to keep the system up-to-date, stable, and aligned with evolving requirements. This includes applying updates, bug fixes, and implementing system enhancements based on user feedback and changing business needs. Additionally, continuous monitoring of system performance, security, and user feedback is crucial for ongoing improvement. By monitoring the system, issues such as performance bottlenecks, security vulnerabilities, and user experience problems can be identified and addressed promptly. This ensures that the Inventory Management System remains reliable, secure, and optimized, providing an efficient and satisfying user experience. By emphasizing deployment and maintenance, organizations can ensure the long-term success and effectiveness of their Inventory Management System. </p>


## Chapter 3 Execution

Final ER Diagram:
![er_1687834580129](https://github.com/Yajme/Inventory-Management-System/assets/88352665/267e78cb-0999-4cbd-891c-67db6380d8d3)


### Functions:

Inventory Tracking

User can do the following:
* Add Products
* Manage Category
* Manage Suppliers
* Manage stocks
* Manage Warehouses
* Filter by Category
* Search Products w/ or w/o Category
* Delete/Edit Product(WIP)


![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/f8fb022b-5274-4642-88f2-7120628b36c7)


<br><br><br>

  #### Add Products
  -----------------

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/c8c8cdb0-a1e5-48d1-81d7-4f7ac1b06e42)


  Following Fields must be filled:
* ProductID - Unique Identification for individual Products
* ProductName - Product Name 
* ProductDescription - Product with accurate description e.g. -> MineralWater 500ml
* Supplier -> Supplier name can be selected through combobox
* Category -> Category can be selected through combobox
* Quantity -> Initial Quantity
* UnitPrice -> Price of the product

**If the category/supplier appropriate selected item cannot be found, make sure to check if the supplier/category is existent and if not proceed first to manage supplier/manage category**

<br>

#### Manage Category
---
<p> In this Section you can Add/Delete/Edit/View Categories based on products you have. </p><br>

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/2e7182be-4ba3-424d-96f0-84bbe11fc3ee)

<p><br> Press Add category to show Textbox for the category name. once you are done you can press save to save changes</p>

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/28355a0f-6324-4830-b8f0-c685302fb78c)

 <p><br>If you want to delete Categories make sure there is no products that falls to that category then proceed to press the trash icon in the right side of the table, a prompt message will be shown to indicate that you are confirming the deletation. once you confirmed the category will be erased from the table</p>

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/8fd97704-57d0-4cf6-b8eb-efd234863962)

 
 <br><p>If you want to edit categories just make sure to check if it is already existing to prevent confusion to the system and to the user then proceed to press the pencil icon in the right side of the table. Once you are done with the changes proceed to Press save to save changes and you are done</p>

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/743b2135-98fe-4281-bfe3-315fb84de6c4)


 
**The only field to be filled is**: <br>
* Category Name



#### Manage Suppliers
---
<p> Managing suppliers include Adding/Viewing/Editing/Deleting of the suppliers </p>

![image](https://github.com/Yajme/Inventory-Management-System/assets/88352665/336356df-c32c-4e77-8439-34726756fc0a)


_Demo Data does not reflect real data_
