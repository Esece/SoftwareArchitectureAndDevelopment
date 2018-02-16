# Scenarios using ASP.NET MVC

## Components and Roles

**UI**

|Role|Remarks|
|-----|------|
|||

**Presentation**

|Role|Remarks|
|-----|------|
|HTTP Request||
|Authorization||
|Model Binders||
|Validation||
|Action Filters||
|Controllers||
|Serialization|Views, JSON, XML, Reports, etc.|
|HTTP Response||

**Application Services**

|Role|Remarks|
|-----|------|
|Control Flow||
|Status Checking||

**Persistance**

|Role|Remarks|
|-----|------|
|Data Reader||
|Data Updater||
|Caching||

**Domain**

|Role|Remarks|
|-----|------|
|Domain Models|Decision Making|
	
	

### Example 1: Report Generation Pipeline

1) HTTP Request (GET /invoice/INV000123)
2) Authorization (Session -> UserInfo)
3) Model Binding (INV000123 -> InvoiceNumber)
4) Data Read (InvoiceNumber, UserInfo)
5) If exists, serialize to PDF
6) If data exists, return 200. 400 if not.
