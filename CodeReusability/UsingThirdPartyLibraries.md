# Using Third-Party Libraries

### Commonly Used Libraries
* UI Components
  - Frontend: [Bootstrap](http://getbootstrap.com/), [Foundation by ZURB] (https://foundation.zurb.com/), [Semantic UI](https://semantic-ui.com/)
  - Backend: [ComponentOne](https://www.grapecity.com/en/componentone-studio), [DevExpress](https://www.devexpress.com/), [Infragistics](https://www.infragistics.com/), [Telerik](https://www.telerik.com/)
* Logging
  - [log4net](http://logging.apache.org/log4net/), [elmah](https://code.google.com/archive/p/elmah/wikis/MVC.wiki), [NLog](http://nlog-project.org/), [Enterprise Library](https://msdn.microsoft.com/en-us/library/ff648951.aspx)
* Data access, binding, and mapping
  - Entity Framework, [NHibernate](http://nhibernate.info/), [Dapper](https://stackexchange.github.io/Dapper/), [AutoMapper](http://automapper.org/) 
* Reporting and File Exports
  - [ComponentSource](https://www.componentsource.com/), [PdfReport](https://github.com/VahidN/PdfReport)

### Selection Criteria
* Does the library offer solutions to business requirements?
* What are the framework requirements? (i.e. .NET Framework 4+ and MVC 4+)
* What are the dependencies? (None for best. If any, those dependencies must be evaluated carefully.)
* Is it free, open source, or paid but with free trials?
* Licensing

### Also consider the following especially for less popular libraries
* How stable are they?
* How actively are they maintained?
* Can you find many online resources? (One way to find out is by the number of questions and tags at [Stackoverflow](https://stackoverflow.com/tags))

### Design Guidelines for Using Third-Party Libraries
* Set up isolation layers to separate dependencies
  - Do not directly reference third party components in business or domain layers
  - Try configuring before inheriting components
* Do not modify the source code (deadend anti-pattern)

### Watch Out for Version Mismatches
It is extremely easy to run into this problem, and it requires configuration changes in many places.

![alt img](https://raw.githubusercontent.com/Esece/SoftwareArchitectureAndDevelopment/master/_images/ThirdPartyVersionMismatchError.jpeg)

