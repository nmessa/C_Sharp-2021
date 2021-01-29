##base36Encrypt.py
##Author: nmessa
##Date: 10.3.2019

def convertString(word):
    newWord = ""

    #Create a conversion string
    conversion = "0123456789abcdefghijklmnopqrstuvwxyz"

    #change your word from a string into an integer
    number = int(word)

    #Convert the number from base 10 to base 36
    while number > 0:
        remainder = number%36
        #Add character to newWord string
        newWord += conversion[remainder]
        number = number // 36

    #reverse the newWord string
    newWord = newWord[::-1]
    return newWord
        
def encrypt(s):
    #convert to lower case
    s = s.lower()
    ns = ""

    #Make sure string only contains letters, numbers and spaces
    for letter in s:
        if letter.isalpha():
            ns += letter
        elif letter.isdigit():
            ns += letter
        elif letter.isspace():
            ns += letter
        else:
            ns += ""
        

    #Create a eString variable initialized to null string
    eString = ""
    
    #Split the string into words
    words = ns.split()

    #Create an empty list to hold the words of the string
    #to be encrypted
    w = []

    #convert words from base 36 to base 10 integer
    for word in words:
        w.append(int(word, 36))

    #build the encrypted string
    for number in w:
        eString += str(number) + ' '
    return eString

def decrypt(s):
    #convert to lower case
    s = s.lower()
    
    #Create a newString variable initialized to null string
    dString = ""

    #Split the string into words
    words = s.split()

    #Create an empty list to hold the words of the string
    #to be decrypted
    w = []

    #Convert each word into base 36 string
    for word in words:
        w.append(convertString(word))

    #Build the decrypted string
    for word in w:
        dString += word + ' '
        
    return dString

#Get input from the user as lower case      
phrase = input("Enter a phrase: ")

#Encrypt and print the phrase
ePhrase = encrypt(phrase)
print('Encrypted string =',ePhrase)

#Decrypt and print the phrase
dPhrase = decrypt(ePhrase)
print('Decrypted string =',dPhrase)

#Restore the original case
decryptedPhrase = ""
for i in range(len(phrase)):
    if phrase[i].isupper():
        decryptedPhrase += dPhrase[i].upper()
    else:
        decryptedPhrase += dPhrase[i]

print('Decrypted string =',decryptedPhrase)
