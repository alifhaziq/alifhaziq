var myself ={
    name: "muhammad alif haziq bin rosli",
    age:  25,
    stay: "puncak alam",
    gender: "male",
    religion: "islam",
    studied: true,
    course: "dtk",
    pratical: "cloud connect",
    address: {
        address1: "cindai 03-17 astana alam 1",
        address2: "jalan astana 13/3",
        postcode: 42300,
        city: "puncak alam",
        nation: "kuala selangor"
    }
} 

myself.sneakers = ["nike" , "air jordan" , "asics"]
myself.hobby = {
    outdoor : "football",
    indoor : "gymnasium"    
}

myself.sneakers.push ("adidas")
myself.sneakers.unshift ("puma")
myself.sneakers.splice (2, 0, "off white")

console.log("* OBJECT *")
console.log(`name : ${myself.name}
age : ${myself.age}
stay : ${myself.stay}
gender : ${myself.gender}
religion : ${myself.religion}
studied : ${myself.studied}
course : ${myself.course}
pratical : ${myself.pratical}`)
console.log(`fav Sneakers : ${myself.sneakers[2]}`)

console.log("")
console.log("* ARRAY *")
console.log(myself.sneakers)

console.log("")
console.log("* FOR IN  *")
for(var data in myself.hobby){
    console.log(data)
    console.log(myself.hobby[data])
}

console.log("")
console.log("* FOR OF *")
for(var data of myself.sneakers){
    console.log(data)
}

console.log("")
console.log("* VARIABLE AND LET *")
{
    var sv = "harith"
    console.log("nama sv :" , sv)
    {
        let student = "haziq"
        console.log("nama student :" , student)
    }
}

console.log("")
console.log("* ARITHMETIC *")
console.log("x=50 , y=3")
var x = 50
var y = 3

console.log(x + y)
console.log(x - y)
console.log(x * y)
console.log(x / y)
console.log(x % y)

console.log("")
console.log("* operator *")
console.log("a=25 , b=2")
var a = 25
var b =  2

console.log(`a += b = ${a += b}
a -= b = ${a -= b}
a %= b = ${a %= b}`)
console.log(a == b)
console.log(a != b)
console.log(a >= b)
console.log(a <= b)

console.log("")
console.log("* ternary *")
var data = a == b ? true : false
console.log("a == b :" , data)

console.log("")
console.log("* conditions *")
var z = 40
var f = 25
var data = z + f
var subs = f - z

if(z > data){
    console.log("benar : z > data")
    this.mydata(data)
}
else if (z <= data){
    console.log("benar : z <= data")
    this.mydata(subs)
}

else{
    console.log("salah : z < data")
}

function mydata(data){
        console.log(data)
}

function mydata(subs){
    console.log(subs)
}







