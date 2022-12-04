var data = "AfricanJournal";
var f = Encode(data);
console.log("Encoded data:"+f);
console.log("Decoded data:"+Decode(f))
function Encode(data){
  data[0];
	var a = data.substring(0, data.length/2);
	var b = data.substring(data.length/2, data.length);
	var k = "";
	var l = "";

	for (let i = 0; i < a.length; i++) {
    if (i%2 == 0) {
        k += a[i];
        k += b[i];  
    }
    if (i%2 != 0) {
        l += a[i];
        l += b[i];
    }
	}
  console.log(l + k);
}  
function Decode(data){
  var c = data.substring(0, data.length/2 - 1);
	var d = data.substring(data.length/2 -1, data.length);
  var h = "";
  var g = "";
  for (let j = 0; j < c.length; j++) {
    if (j%2 != 0) {
      h += d[j+1];
      h += c[j];
    }
    if (j%2 == 0) {
      g += d[j];
      g += c[j];
    }
  }
  console.log(h);
  console.log(g);
}
            //   var data = "AfricanJournal";
            //   var a = data.substring(0, data.length/2);
            // 	var b = data.substring(data.length/2, data.length);

            //     const firstword = a.ToCharArray();
            //     const secondword = b.ToCharArray();

            //     let newA = string.Empty;
            //     let newB = string.Empty;
            //     var addword = newA + newB;

            //     var i;
            //     for (i = 0; i <= firstword.Length - 1; i++)
            //     {
            //         let even = i % 2 == 0;
            //         let odd = i % 2 != 0;
            //         if (even)
            //         {
            //             newA += firstword[i] + "" + secondword[i];

            //         }
            //         else if (odd)
            //         {
            //             newB += firstword[i] + "" + secondword[i];
            //         }

            //     }
            //  let add = newB + newA;
            //     const charArray = add.ToCharArray();
            //     let reverse = "";
            //     for (let j = charArray.Length - 1; i > -1; i--)
            //     {
            //         reverse += charArray[i];
            //     }
            //     console.log(reverse);
