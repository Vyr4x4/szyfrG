def gaderypoluki(Text)
cipher_dict = {
    'a': 'g', 'b': 'a', 'c': 'd', 'd': 'e', 'e': 'r',
    'f': 'y', 'g': 'p', 'h': 'o', 'i': 'l', 'j': 'u',
    'k': 'k', 'l': 'i', 'm': 'g', 'n': 'a', 'o': 'd',
    'p': 'e', 'q': 'r', 'r': 'y', 's': 'p', 't': 'o',
    'u': 'l', 'v': 'u', 'w': 'k', 'x': 'i', 'y': 'g', 'z': 'a'
}
encrypted_text = ""
    for char in text.lower():
        if char in cipher_dict:
encrypted_text += cipher_dict[char]
        else:
            encrypted_text += char
    return encrypted_text;
