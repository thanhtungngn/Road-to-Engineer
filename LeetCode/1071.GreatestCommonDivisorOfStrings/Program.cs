// See https://aka.ms/new-console-template for more information
Console.WriteLine(GcdOfStrings("ABABAB", "ABAB"));

string GcdOfStrings(string str1, string str2) {
    var result = "";
    var longerString1= str1.Length > str2.Length;
    if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2)){
        return result;
    }
    if(longerString1) {
        var index = str2.Length-1;
        var oldString = str2;
        while(index >=0 && string.IsNullOrEmpty(result)){
     
            if(Divisible(str1, str2) && Divisible(oldString, str2)){
                result = str2;
            }
            else {
                str2 = str2.Remove(index);
                index --;
            }
        }
    }
    else {
        var index = str1.Length-1;
        var oldString = str1;
        while(index >=0 && string.IsNullOrEmpty(result)){
          

            if(Divisible(str2, str1) && Divisible(oldString, str1)){
                result = str1;
            }
            else {
                str1= str1.Remove(index);
                index --;
            }
        }
    }
    return result;
}

bool Divisible(string str1, string str2) {
    var splitWords = str1.Split(str2);
    foreach(var word in splitWords) {
        if(!string.IsNullOrEmpty(word)){
            return false;
        }
    }
    return true;
}
