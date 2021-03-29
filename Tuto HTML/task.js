var person = [{
        name: "haziq",
        age: 25,
        isEmployed: true,
        familymembers: ["fariq", "amira", "akira", "hadi"]
    },
    {
        name: "rosli",
        age: 52,
        isEmployed: true,
        familymembers: ["rohana", "rohani", "hawa"]
    },
    "ahmad",
    5
]

if (person) {
    var data = this.showArrayObj(person)

    data.map(z => {
        console.log(z)
    })
}

function showArrayObj(data) {
    let localArr = []
    data.map(x => {
        if (typeof(x) == "object") {
            let value = `name : ${x.name} age : ${x.age} isEmployed : ${x.isEmployed} Family Member : ${x.familymembers}`
            localArr.push(value)
        } else {
            let value = x
            localArr.push(value)
        }
    })
    return localArr
}


console.log("")
var a = 10
var b = 23
var c = 5

if (a == 10 && b == 23) {
    this.calculate(a, b)
} else {

}

function calculate(a, b) {
    console.log(a * b)
}

console.log("")
var data = c != 10 ? true : false
console.log(data)
this.calculate(a, b, c)

function calculate(a, b, c) {
    console.log(a + b + c)
}