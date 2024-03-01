const userinfo = [
  { username: "Balaji", dept: "cse", place: "salem" },
  { username: "Bala", dept: "mech", place: "che" },
  { username: "ji", dept: "it", place: "blr" },
];

const MatchingData = userinfo.map((x) => {
  if (x.place == "che") return { x };
});
MatchingData;

const FilterSample = userinfo.filter((x) => x.place == "blr" && x.dept == "it");
FilterSample;

FilterSampleApp2 = userinfo
  .filter((x) => x.place == "blr")
  .filter((x) => x.dept == "it");
FilterSampleApp2;
