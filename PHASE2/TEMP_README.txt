Titles
TextBoxes: TitleId, Title, Type, Price, Advance, Royalty, Notes

ComboBox: Publisher (PubId)

DateTimePicker: PubDate

TextBox (Disabled): YtdSales (optional read-only)

Buttons: Add, Clear





Authors
TextBoxes: AuId, FirstName, LastName, Address, City, State

MaskedTextBox: Phone, Zip

CheckBox: Contract

Buttons: Add, Clear

Publishers
TextBoxes: PubId, PubName, City, State, Country

Buttons: Add, Clear





Stores
TextBoxes: StorId, StorName, Address, City, State

MaskedTextBox: Zip

Buttons: Add, Clear





Employees
TextBoxes: EmpId, FirstName, LastName, Level

ComboBox: JobId (reference to Jobs table)

DateTimePicker: HireDate

Buttons: Add, Clear





Shopping Cart / Order Screen
TextBox: Search by partial title

DataGridView: Search results (Title, Price, Publisher)

NumericUpDown or TextBox: Quantity entry

DataGridView: Current cart items (Title, Qty, UnitPrice, LineTotal)

Labels: Subtotal, Tax, Total (auto-updated)

Buttons: Add Item, Update Qty, Remove Item, Commit Order





Invoice / Receipt Screen
Labels: OrdNum, Customer/Store, Employee, Order Date

DataGridView: Line items (Title, Qty, UnitPrice, LineTotal)

Labels: Subtotal, Tax, Total

Button: Close/Confirm





Sales Report Screen
DateTimePickers: Start Date, End Date

Button: Generate Report

DataGridView: Results (OrdNum, TitleId, Title, Qty, OrdDate, LineTotal)

Button: Export/Save (CSV or text file)





Main Menu Screen
Buttons:

Titles Maintenance

Authors Maintenance

Publishers Maintenance

Stores Maintenance

Employees Maintenance

Shopping Cart / Order

Invoice / Receipt

Sales Report

Optional: MenuStrip for navigation instead of buttons.