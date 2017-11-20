w4LCj0fDlUTDg8KPK1osw4Niw6pxw5dzBMOtQcK0wrwRHhPDlsKjHMOaw4HDgEsO

public static string ConvertFrom(string cipherString, string Key)
{
	uint[] k = UTF8Conv.FormatKey(Key);
	byte[] array = Convert.FromBase64String(cipherString);
	string @string = Encoding.get_UTF8().GetString(array, 0, array.Length);
	int num = 0;
	uint[] array2 = new uint[2];
	byte[] array3 = new byte[@string.get_Length() / 8 * 2];
	for (int i = 0; i < @string.get_Length(); i += 8)
	{
		array2[0] = UTF8Conv.ConvertStringToUInt(@string.Substring(i, 4));
		array2[1] = UTF8Conv.ConvertStringToUInt(@string.Substring(i + 4, 4));
		UTF8Conv.decode(array2, k);
		array3[num++] = (byte)array2[0];
		array3[num++] = (byte)array2[1];
	}
	string text = Encoding.get_ASCII().GetString(array3, 0, array3.Length);
	if (text.get_Chars(text.get_Length() - 1) == '\0')
	{
		text = text.Substring(0, text.get_Length() - 1);
	}
	return text;
}

--
	array[0, 0] = "Developer";
	array[0, 1] = UTF8Conv.ConvertFrom("w4LCj0fDlUTDg8KPK1osw4Niw6pxw5dzBMOtQcK0wrwRHhPDlsKjHMOaw4HDgEsO");
	array[1, 0] = "Service";
	array[1, 1] = UTF8Conv.ConvertFrom("RTTCnzLCksOnTk5ow7FrI0lZwp7CmG4+Wg0ZL8OIacK1U8OEXcKgwqjDo8KUwqTDtcKCDCxITcO5bMOST8KFwp48McKr");
	array[2, 0] = "Installer";
--
// nSecurity.cSecurity
public static string OldServicePassword
{
	get
	{
		return UTF8Conv.ConvertFrom("UcO8w4V/wqrDpcOjw6BueMOWwpbChX4Fag==");
	}
}
--
// nSecurity.cSecurity
public static string ServicePassword
{
	get
	{
		return UTF8Conv.ConvertFrom("RTTCnzLCksOnTk5ow7FrI0lZwp7CmG4+Wg0ZL8OIacK1U8OEXcKgwqjDo8KUwqTDtcKCDCxITcO5bMOST8KFwp48McKr");
	}
}
--
// nSecurity.cSecurity
public static string DeveloperPassword
{
	get
	{
		return UTF8Conv.ConvertFrom("w4LCj0fDlUTDg8KPK1osw4Niw6pxw5dzBMOtQcK0wrwRHhPDlsKjHMOaw4HDgEsO");
	}
}
--
// nSecurity.cSecurity
public static string ForceLogoutPassword
{
	get
	{
		return UTF8Conv.ConvertFrom("wpLCqUUhZMKjLQEtHEfCpMKxwonCn8Kowq3CoiMqw77CmxPCqsOMNXwjw6RDw4nDqlVXwrkefy5ND0kYwrZhMMOuw7LDl01iwo7CusOxwpVow4s=");
	}
}
--
