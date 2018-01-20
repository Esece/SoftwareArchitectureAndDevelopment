bool flag = true;  // NO NEED TO INITIALIZE, IN FACT, VALUE FALLS BACK TO 'false' WHEN TryParse FAILS 
bool success = bool.TryParse("1true", out flag);
