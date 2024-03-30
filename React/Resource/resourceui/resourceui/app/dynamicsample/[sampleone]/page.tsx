export default function SampleOnePage({ params }) {
  //const router = useRouter();
  // The query object has a `slug` property because of the file name `[slug].tsx`
  //const { sampleone } = router.query;
  console.log(params);
  return <h1>Sample one: Called by {params.sampleone}</h1>;
}
