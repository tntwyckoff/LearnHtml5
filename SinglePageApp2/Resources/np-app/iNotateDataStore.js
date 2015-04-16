
var allTitles =
[
    {
        "Id": 540346,
        "Type": 'Book',
        "Name": 'Hitch 22',
        "Description": 'Christopher Hitchens\' autobiography',
        "Notes": []
    },

    {
        "Id": 249771,
        "Type": 'Book',
        "Name": 'ASP.NET MVC 4 and the Web API',
        "Description": 'Buyilding a REST service from Start to Finish',
        "Notes": []
    }
];

var allNotes =
[
    {
        "Id": 4,
        "TitleId": 540346,
        "Date": '2014-01-01T12:00:00.000Z',
        "PageNumber": 4,
        "Title": "Talks about Alfred Nobel",
        "FullText": "I'm not 100% sure why i marked this, except maybe to remember the circumstance - he was compensating for having worked on explosives his whole life and created the peace prize to make amends."
    }
];

allTitles.forEach (function (value, number, traversedObject)
{
    traversedObject.Notes = jQuery.grep (allNotes, function (currObj, i){
        currObj.TitleId === traversedObject.Id
    });
});

[
    {
        "Id": 1,
        "Items": allTitles,
    }
]