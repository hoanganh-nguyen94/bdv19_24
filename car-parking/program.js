var fs = require('fs');

fs.writeFile('./output.txt', "hello the world", (err) => {
    if (err) throw err;
    console.log('done');
});