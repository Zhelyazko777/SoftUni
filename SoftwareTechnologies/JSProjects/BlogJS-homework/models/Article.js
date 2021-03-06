const mongoose = require("mongoose");
let articalSchema = mongoose.Schema({
    title: {type: String, required: true},
    content: {type: String, required:true},
    author: {type: mongoose.Schema.Types.ObjectId, required: true, ref: "User"},
    data: {type: Date, default: Date.now()}
})

const Article = mongoose.model("Article", articalSchema);
module.exports = Article;