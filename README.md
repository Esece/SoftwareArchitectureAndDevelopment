# Software Architecture and Development

## Languages and Technologies Used:
C#, JavaScript, T-SQL, CSS, HTML, ASP.NET MVC, Bootstrap, jQuery, AngularJS

## Key Engineering Philosophies:
* Efficient
* Simple
* Extendable
* Composable
* Easy to Maintain

### EFFICIENT
  #### Project Management
  - Understand and reduce task dependencies
  ##### Development
  - Use code generators
  - Utilize separate coding scratch pads like LinqPAD and JSFiddle for quick debugging
  ##### Process
  - Balance the goals of design and performance
  - Understand user behavior to design data flow and its timing
  - Know general performance of common standard library components
  - Avoid remote calls or reduce the number of remote calls if possible
  ##### Testing and Debugging
  - Write easy-to-test code
  - Set up dependency mocks
  
### SIMPLE
  ##### Application Design
  - Balance usability and user experience
  - User stories and acceptance criteria
  ##### Coding
  - Reuse third-party components where they meet your requirements
  - Small methods with single responsibility
  - Establish common flow controls
  ##### Dependency Management
  - Use Layers and set up rules for each

### EXTENDABLE
  ##### Reusability
  - Open Close Principle
  - Prototyping by extending first and minimize impact to existing functionality

### COMPOSABLE
  ##### Favor composition over inheritance
  - Inherit interface, not implementation
  - Encapsulation can also be achieved with abstract base class
  ##### Micro Services
  - Minimal, self-contained, independently-deployable services  

### EASY TO MAINTAIN
  ##### Continuous integration
  - Having a code repository is a must.
  - Automate builds
  ##### Deployment
  - Avoid release dependency
  - Employ Blue/Green Deployment
  - Allow runtime changes and modification if possible, such as CMS, to avoid deployment
  ##### Performance Improvement
  - Avoid micro-optimization
  ##### Logging
  - Set logging rules
  - Monitor key indicators proactively
  - Make the level of logging configurable (ideally even at runtime)
  ##### Bug Fixing
  - Create two tasks for unplanned release (Short term and long term)

  
  



