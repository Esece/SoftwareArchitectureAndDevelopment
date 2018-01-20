///////////////////// BEFORE /////////////////////

var value = "123";
int id;

if (value != null && int.TryParse(null, out id))  // NO NEED TO NULL CHECK...
{
    //
}


///////////////////// AFTER //////////////////////

var value = "123";
int id;

if (int.TryParse(null, out id))
{
    //
}
