Design Notes for DB Docs Editor
===============================

The idea of the tool is to provide an end user tool for editing the DBDocs Tables.
- The main focus is the system being dynamic, so very little hardcoded settings.

The Main DBDocs system consists of Three tables that link to each other and existing tables

DBDocsTables    - This contains an entry for each Table in the DB, Linked By TableName
DBDocsFields    - This contains an entry for each field in tht DB, Linked by TableName and FieldName
DBDocsSubTables - These a self contained tables of data which can be insert anywhere in the above tables




GUI Screens
===========
1) Database Login and selection screen.

2) Tables Screen

3) Fields

4) SubTables

1) Usual style screen, but you like to add some ability to save server details
   - so that they can be presented in a list to the user to select servers

2) Tables screen opens the selected database, then reads the list of tables from the database.

* Populates a listbox containing all the tables in this database.

* When a user clicks on a table, the information onscreen is updated with the relevant info.
This includes a lookup to the DBDocsTables table to pulling that info into the screen.

* This screen also has Buttons to Open Fields and SubTables.

**Extra** - For all the subtables referenced in the notes, provide a link to open them in a SubTable Window

3) Fields screen performs a lookup on the database against the selected table.

* Populates a listbox containing all the fields in this table

* When a user clicks on a field, the information onscreen is updated with the relevant info
	  This includes a lookup to the DBDocsTables table to pulling that info into the screen.

* This screen also has a Button for SubTables.

**Extra** - For all the subtables referenced in the notes, provide a link to open them in a SubTable Window

4) SubTables screen reads a list of subtables from the db and generates a list.
* subTableNotes will be used for the names in the listbox.

* When a user clicks on a subtable, the information onscreen is updated with the relevant info




General Notes
=============

Look at extending dbdocsSubtables to include a 'template' field which will contain the information used by
table builder to generate the HTML table markup.

* This would allow the DBDocs Editor to Add/Update the generated tables.

* Add the table builder to the app.
* Add the HTML render to the app, so that the Tables can be created on the fly.