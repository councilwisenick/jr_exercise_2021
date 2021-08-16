# jr_exercise_2021
Simple programming exercise for junior developer candidates

# Requirements:

* Given a list of receipt items where TaxAmount is not populated, calculate the correct tax for each receipt item. If IncludesGST is true, the unit price contains tax already. (In this case you will need to divide by 11 to get the tax amount). 
    * If includesGST is false, the unit price does not contain tax and you will need to calculate it (multiply by 0.1 for tax amount). 
* Return a populated Receipt object which contains the receipt items including tax amounts with the correct totals.
    * Note that all totals shown on the receipt should be tax inclusive, including the receipt item totals.
* For bonus points, if the receipt item name is a palindrome, the receipt item unit price should be changed to free. 
    * A palindrome is a string which reads the same way forwards and backwards
* You may modify the Receipt ReceiptItem and Helper classes any way you like as well as add new classes, but you must call the ProcessReceiptItems() method and the Receipt.ToString() method in your test case and no other methods. 
* Add additional test cases to cover any edge cases you can think of

  Expected Output:

  Print a receipt to the console with the following format:
`
  Receipt:
    Items:
    <Name>
      <Quantity>		<UnitPrice>		<Total inc. Tax>
    <Name>			
      <Quantity>		<UnitPrice>		<Total inc. Tax>
    ... for all receipt items
  Total:	<Total inc. Tax>
  GST:	<TaxTotal>
`
