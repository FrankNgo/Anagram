# Address Book

This is a web based application that allows users to add contacts to an address book.  The home landing allows the user to create new contacts or delete all contacts.  Clicking on the "add new contact" hyper link takes the user to a form that allows them to enter in a contact name, phone number, and address and then allows the user to submit the form with the "add contact" button.  The user is then taken to the home landing page where they can add another contact, click on their newly created, or click on a previously created contact to view the details of that contact.  Clicking on a contacts name from the list of contacts takes the user to a page where they can view their entered information.  The details page also has hyper links to the home page or the add contacts page.  Clicking on the delete all button on the home page will remove all contacts.

### Prerequisites

Have a working Terminal and a working web browser

### Installing

  * Open Terminal
  * Cd to desktop or where user would like to store directory by typing in: cd Desktop
  * Copy application contents by typing in your Terminal: git clone https://github.com/FrankNgo/Address-Book.git
  * Navigate to the application directory by typing in: cd Address-Book
  * Restore the applications dependencies by typing in: dotnet restore
  * Build the application by typing in: dotnet build
  * Run and open the application by typing in: dotnet run
  * Open any browser
  * Type in the browser URL http://localhost:5000/ to access the application

## Specifications

  * The User can add new contacts to the list.
  * The User can enter in all info fields and create a new contact.
  * The User can click on contacts and view the information they entered for each contact.
  * The User can go to the homepage or add new contracts from the details page.
  * The User can remove all contacts with the "clear all contacts" button.

## Running the tests

  * Click on the "Add New Contact" Button
  * Enter in information and click "Add Contact"
  * Click a contacts name and view contact Info
  * Click on "Add Another Contact"
  * Click on "View ALl Contacts"
  * Click on "Clear All Contacts"

### Bugs and Tests

No known bugs

## Built With

* HTML - The web framework used
* C# - The programming language used
* CSS - Style Library
* [bootstrap](https://getbootstrap.com/docs/3.3/) - Style Library
* [jquery](https://jquery.com/download/) - Javascript Library


## Authors

* Frank Ngo https://github.com/FrankNgo

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
