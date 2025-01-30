# Alma Association - Food Distribution System

## Overview
Alma Association, founded in memory of Liat Yanai, provides food packages to families in need. The association's main goal is to offer regular food distribution to around 360 families, helping to provide basic nutrition and support to those in need. The system is designed to optimize and streamline several key processes within the organization, such as:

- **Supplier Management**: Efficient price comparisons and order tracking.
- **Volunteer Coordination**: Assigning volunteers to tasks during food packaging days.
- **Donor Engagement**: Maintaining a list of recurring donors and facilitating future donations.
- **Food Distribution Logistics**: Managing the distribution process, including vehicle allocation and tracking deliveries.

## Features
### 1. **Supplier Management**
- **Price Comparison**: The system allows for comparing prices from different suppliers for food packages.
- **Order Management**: Allows tracking of orders, ensuring timely and cost-efficient procurement of food.
  
### 2. **Volunteer Coordination**
- **Task Assignment**: Volunteers can be assigned to packaging, driving, and other essential tasks.
- **Volunteer Feedback**: Volunteers and families can leave feedback regarding their experience.

### 3. **Donor Management**
- **Donor Tracking**: Keep track of donations, including those made through recurring payments.
- **Donor Communication**: Automated thank you messages and reminders about upcoming donation opportunities.
- **Website Integration**: The association is integrating a website for easy donation collection and donor engagement.

### 4. **Logistics**
- **Delivery Routing**: The system automatically assigns drivers to delivery routes based on geographical preferences and availability.
- **Family Coordination**: The system keeps track of food deliveries and schedules, ensuring each family receives their food packages.

### 5. **Inventory Management**
- **Stock Monitoring**: Real-time updates on inventory, showing what items are low and need to be reordered.
- **Automated Reordering**: Based on stock levels, the system can recommend orders to ensure supply aligns with demand.

## Technologies Used
- **Web System**: The system will be developed to run efficiently through a web interface, providing accessibility for managers, volunteers, and donors.
- **Database**: A database will store all the information related to volunteers, donors, suppliers, and families receiving assistance.
- **Automated Messaging**: Using WhatsApp and email for efficient communication with all involved parties.
  
## Functional Requirements
1. **Supplier Interaction**: The system will help manage interactions with food suppliers, track orders, and provide price comparisons to ensure the lowest possible cost.
2. **Volunteer Coordination**: The system will allow volunteers to register for tasks, manage their assignments, and ensure everyone is appropriately allocated.
3. **Donor Engagement**: With integrated donor management features, the system ensures ongoing communication and facilitates recurring donations.
4. **Delivery and Inventory Management**: The system will facilitate efficient inventory management, delivery assignments, and scheduling of food packages.

## Non-Functional Requirements
- **System Accessibility**: The system will be accessible via desktop and mobile (iOS) to facilitate easy management and real-time updates.
- **Security**: Data will be securely stored and backed up to ensure no loss of information.
- **Usability**: The system will feature an intuitive user interface for administrators, volunteers, donors, and beneficiaries.

## Goals of the Project
- **Optimize Communication**: Centralize communication between volunteers, suppliers, donors, and beneficiaries.
- **Streamline Operations**: Automate the most time-consuming tasks such as pricing, orders, and volunteer assignment.
- **Improve Tracking**: Make it easier to track donations, deliveries, and volunteer activities.

## How to Use the System
1. **Log in**: Volunteers, donors, and staff will be able to log into the system using their credentials.
2. **Assign Tasks**: Administrators can assign tasks to volunteers, such as packaging or delivery.
3. **Track Donations**: Donors can view their donation history and upcoming opportunities.
4. **Generate Reports**: Administrators can generate reports on inventory, donations, and volunteer activities to track performance.

## Future Enhancements
- **Mobile App**: A mobile application for easy access to volunteer schedules, food delivery statuses, and donations.
- **Expanded Donor System**: A more robust donor management system allowing for targeted campaigns and automated thank you notes.
- **Advanced Analytics**: Implement data analytics to track food usage patterns and better predict future needs.

## Installation and Setup
To run the system, ensure you have the following installed:
- **Database Setup**: MySQL or PostgreSQL for data storage.
- **Web Framework**: React or Angular for the front-end and Node.js for the back-end.
- **Messaging APIs**: WhatsApp API integration for volunteer and donor communication.

Run the following commands to set up your environment:
```bash
npm install
npm start
