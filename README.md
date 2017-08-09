# specflow-example
This is a small example of an Automation suite that uses SpecFlow. It has a simple test that goes to Google, performs a search, and then validates the search results.

Most of the notable content is within four folders: Features, Pages, Steps, and Hooks.

### Features folder
This contains the feature files. These are the gherkin-style tests that are written at the high level

### Pages folder
This contains the Page files. Page files typically contain the elements you'd find on the page. They can also contain basic logic for the page

### Steps folder
This contains the Step files. These are where all the actual automation logic happens. The Feature files will point to these files, and these files have all the actual C# code that runs the automation
 
### Hooks folder
This contains the logic to be executed before and after tests. Cleaning up the webdriver, for example, should be done in the Hook files.
