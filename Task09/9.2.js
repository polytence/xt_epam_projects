function calc(str) {
		var result = 0,
			matchArr = [],
			regex = /\-?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1}/ig;
      //var newstr = str.replace("-", "- ") // if -5.3 not negative. like - 5.3


		matchArr = str.match(regex);

		if(matchArr[0]*1+"" !== "NaN") {
			result += matchArr[0]*1;
		}
        

		for(var i = 0; i < matchArr.length; i++) {
debugger;
			switch(matchArr[i]) {
				case "+": result += matchArr[i+1] * 1; break;
				case "-": result -= matchArr[i+1] * 1;  break;
				case "*": result *= matchArr[i+1] * 1; break;
				case "/": result /= matchArr[i+1] * 1; break;
				case "=": break;
				default: continue; break;
			}
		}

		return result;
	}

	var test = "3.5 +4*10-5.3 /5 =";
	console.log(calc(test).toFixed(2));