var str = "У попа была собака";
var separator = ["?", "!", ":", ";", ",", ".", " ", "\t", "\r"];
var letters = {};
var words = str.split(' ');

words.forEach(function (word) {
    word.split('').forEach(function (letter, i) {
        if (!letters[letter] && separator.indexOf(letter) == -1 && -1 != word.indexOf(letter, i + 1)) {
            letters[letter] = 1;
        }
    });
});

str = str.split('').filter(function (v) {
    return !letters[v];
}).join('');
console.log(str);
