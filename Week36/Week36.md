## Why should we test?
1. Discover and solve problems
2. Meet stakeholder’s expectations
	1. Functional and non-functional requirements 
3. Legal obligations
4. Reducing the risk of using the software
When testing, reducing the time and resources designated for the testing phase will directly increase the risk of using the software.

## Types of tests
### Functional testing – what it does
Also referred as specification based, in which any program can be considered as a function that maps values from its input domain to values in its output range. In engineering, this is commonly referred as black box systems, which led to another synonymous term, black box testing, in which the implementation of the black box is unknown and its function is completely understood in terms of its inputs and outputs.

### Non-functional testing – how (well) it does it
Also referred as code based, white box or clear box testing due to being able to access the implementation of the program.
This ability to see inside the black box allows the tester to identify cases based on the actual implementation of the functionalities.
We focus on the usability, efficiency, security, reliability, and other forms of “itilities”.

### Testing related to changes / maintenance
Regression Testing is defined as a type of software testing to confirm that a recent program or code change has not adversely affected existing features.
Regression Testing is nothing but a full or partial selection of already executed test cases which are re-executed to ensure existing functionalities 
work fine.

## Test techniques
### Static testing
* **Review** -> a human is the defect finder
* **Static analysis** -> a tool is used to analyse the test object and find possible defects and other issues. The test object can be the code or the system architecture.

### Dynamic testing
Involves executing the software:
* **Specification-based** (black box)
* **Structure based** (white box, clear box, code based)
* **Defect and experience based** -> tests are created based on the tester’s intuition, experience and knowledge about potential defects.
* **Dynamic analysis** -> special tools are used to monitor the system as it runs, and log results. Specially useful for finding failures that cannot be replicated.

## Traditional waterfall testing
![traditional waterfall testing](https://www.coleyconsulting.co.uk/images/Bent-Waterfall.gif)

Is a linear sequential design approach in which the progress flows in one direction.

### V-model
![v-model waterfall testing](https://www.360logica.com/blog/wp-content/uploads/2016/06/image001.jpg)

Also known as Verification and Validation model or bent waterfall, demonstrates the relationships between each phase of the development life cycle and its associated phase of testing.
While tests are just one of five steps in Waterfall, it looks like practically half of the process in V-model.

### W-model
![w-model waterfall testing](https://www.sphammad.com/uploads/4/7/1/3/4713847/the-w-model_orig.png)

The W-model is a variation of the V-model which covers those testing activities left uncovered by the former, ensuring that the testing starts from the first phases of the project and not only after the development phase is done.

## Agile testing
Customers express their expectations in terms of user stories, which are taken as the requirements for very short iterations of design-code-test. Agile projects end when the customer does not have any more user histories.
* Agile development recognises testing as an integral part of software development, along with coding
* Testing and coding are done incrementally and iteratively
* Agile testing covers all types of testing
* Most test planning and execution occur during iterations

## Verification and validation
* Verification -> are we building the product right?
* Validation -> are we building the right product?
In Agile testing methodologies, there are many more opportunities to validate than in the waterfall model.

- - - -
## Unit test
A unit test is an automated piece of code that invokes the unit of work being tested, and then checks some assumptions about a single end result of that unit.
* Almost always written using a unit testing framework
* Its scope can span as little as a method or as much as multiple classes
* Can be written easily and runs quickly
* Trustworthy, readable, repeatable, independent and maintenable
* Consistent in its results as long as the implementation of the code tested isn’t altered

## Unit of work
A unit of work is the sum of actions that take place between the invocation of a public method in the system and a single noticeable end result by a test of that system.
A end result can be: 
* The invoked method’s return value or an exception
* A noticeable, public state change of the system being tested
* There is a call to a third-party system over which the test has no control over

## Integration test
Integration testing is testing a unit of work without having full control over it and using one or more of its external dependencies.
External dependencies include:
* File system
* Database
* Web service

## Naming conventions for unit tests
* Project -> create a test project named `[ProjectUnderTest].UnitTests`
* Class -> create a class named `[ClassName]Tests`
* Unit of work -> create a test method named `[UnitOfWorkName]_[ScenarioUnderTest]_[Expe