Runtime : 55ms - 83%
Memory: 39.09 - 24%

Memory is using a lot because of String datatype instead of StringBuilder datatype.
Whenever we add new character to this String, it will create new String instance and copy all old character.
If we have a string with 1000 chars, 1000 instances is created.

