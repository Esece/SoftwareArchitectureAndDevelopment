## Managing Bugs

#### A bug ticket is created usually when there is a discrepancy between a requirement and an actual behavior

> Testing should be conducted based on the written acceptance criteria. If a critical issue is found during the testing period, the team will need to review new requirements before formally testing for a bug.

Prioritizing Bugs

|Severity|What is It|When to Fix|Examples|
|-----|-----|-----|-----|
|Critical|There are no other ways to complete the operation|Current iteration|"The system cannot process any purchase order."|
|High|There are some other ways to accomplish similar goals|Current if possible|"User master cannot be uploaded but can be entered manually."|
|Normal|There are some other ways to do the same thing|Current or next|"One of the hyperlink is broken, but you can get to the same page from another hyperlink."|
|Low|Visual imperfection, broken convenience features|Next|"Misaligned text," "Autofill not wokring," "Incomplete or missing client side validation"|

#### A bug ticket should have a link to the test case which should also be linked to the original requirement.


Example of a Bug

**Issue:**
```
A read-only user can see the settings button in the top navigation bar.
```
**Expected (Test Case):**
```
The settings button in the top navigation bar is not visible to the read-only users.
```
**Requirements:**
```
The buttons and links to the settings are only visible to the admin users.
The read-only user does not have access to the settings.
```
