var ptss = {
    name : "politeknik tuanku syed sirajuddin",
    place: "perlis",
    city : "arau",
    poscode : 42300,
    department : {
        jke: ["dtk" , "doe" , "dep"],
    }
}
ptss.cafe = ["siswa" , "siswi"]
ptss.kamsis = {
    masjid: "Pusat islam",
    blok : ["a3" , "a4" , "a5"]
}


var jkrv = ["ddv" , "dds"]
jkrv.push("dkm")
jkrv.unshift("kkm")
jkrv.splice(2 , 0 , "jph")

console.log(`name: ${ptss.name} 
place: ${ptss.place}
city:  ${ptss.city}
poscode: ${ptss.poscode}
department: ${ptss.department.jke}
cafe: ${ptss.cafe}
blok kamsis: ${ptss.kamsis.blok}`)


console.log("")
console.log(jkrv)

console.log("")
for(var data in ptss.department.jke){
    console.log(ptss.department.jke[data])
    console.log(typeof(ptss.department.jke[data]))
}

console.log("")
for(var data of jkrv){
    console.log(typeof (data))
}

console.log("")
jkrv.map(x => {
    console.log(`${x}`)
})

console.log("")
{
    var x = "haziq";
    console.log(x)
    {
        let x = "harith";
        console.log(x)
    }
    console.log(x)
}

console.log("")
console.log("arithmetic")
console.log("x = 10 , y = 3")
var x = 10
var y = 3

console.log("x + y =", x + y)
console.log("x - y =" , x-y)
console.log("x * y =" , x * y)
console.log("x / y =" , x / y)
console.log("x % y =" , x % y)
console.log("x ** y =" , x ** y)

console.log("")
console.log("operator")
console.log("a = 25 , b = 5")
var a = 25
var b = 5

console.log("a == b =" , a == b)
console.log("a != b =" , a != b)
console.log("a >= b =" , a >= b)
console.log("a > b =" , a > b)
console.log("a < b =" , a < b)

console.log("")
console.log("ternary")
console.log("a = 25 , b = 5")
var data = a == b ? "betul" : "salah"
console.log(`a == b : ${data}`)

console.log("")
console.log("conditions")
var nama = 12

if(nama == 12){
    console.log("betul :" , nama)
}
else{
    console.log("salah : nama = 12")
}

console.log("")
console.log("functions")
var d = 11
var e = 5
var f = 6
var g = 1

if(d < 10){
    this.mydata(e, d, f)
    
}
else if(d <= 10){
    this.mydata(d)
}
else{
    this.mylist()

}

function mydata(d){
    console.log("data :", d)
}

function mydata(e, d, f){
    console.log(e + d + f)
}

function mylist(){
    console.log("hello everything")
}






